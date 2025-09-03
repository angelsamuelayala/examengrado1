using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace fotomaster
{
    public partial class FormClientefoto : Form
    {
        private DataTable dtClientes = new DataTable();
        private int idClienteSeleccionado = 0;
        public FormClientefoto()
        {
            InitializeComponent();
            CargarClientes();

            // 🔹 Conectar eventos del buscador
            txtBuscarCliente.TextChanged += txtBuscarCliente_TextChanged;
            listClientes.Click += listClientes_Click;
            // 🔹 Ocultar el ListBox al inicio
            listClientes.Visible = false;
            this.dgvFotos.CellClick += new DataGridViewCellEventHandler(this.dgvFotos_CellClick);
           // this.btndescargar.Click += new EventHandler(this.btndescargar_Click);
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin();
            admin.Show();
            this.Close();
        }

        private void CargarClientes()
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT c.idCliente, CONCAT(p.nombre, ' ', p.apellido) AS nombreCompleto
                FROM Cliente c
                JOIN Persona p ON c.idCliente = p.idPersona";

                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    dtClientes.Clear();
                    da.Fill(dtClientes);

                    // Al inicio no mostramos nada en el ListBox
                    listClientes.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar clientes: " + ex.Message);
                }
            }
        }

        private void CargarFotosCliente(int idCliente)
        {
            using (MySqlConnection con = Conexion.ObtenerConexion())
            {
                try
                {
                    con.Open();
                    string query = @"
                SELECT idFoto, fotobinario, fecha
                FROM fotodigital
                WHERE idCliente = @idCliente";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dtFotos = new DataTable();
                    da.Fill(dtFotos);

                    // Limpiar columnas para evitar duplicados
                    dgvFotos.Columns.Clear();

                    // Convertir BLOB en imagen
                    DataTable dtConImagen = new DataTable();
                    dtConImagen.Columns.Add("Foto", typeof(Image));
                    dtConImagen.Columns.Add("Fecha", typeof(DateTime));

                    foreach (DataRow row in dtFotos.Rows)
                    {
                        byte[] bytesImagen = (byte[])row["fotobinario"];
                        using (var ms = new System.IO.MemoryStream(bytesImagen))
                        {
                            Image img = Image.FromStream(ms);
                            dtConImagen.Rows.Add(img, row["fecha"]);
                        }
                    }

                    dgvFotos.DataSource = dtConImagen;

                    // Ajustar visualización
                    dgvFotos.RowTemplate.Height = 100;
                    dgvFotos.Columns["Foto"].Width = 100;
                    ((DataGridViewImageColumn)dgvFotos.Columns["Foto"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    //dgvFotos.RowHeadersVisible = false;
                   // dgvFotos.AllowUserToAddRows = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar fotos: " + ex.Message);
                }
            }
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscarCliente.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                listClientes.DataSource = null;
                listClientes.Visible = false; // ocultar si no hay texto
                return;
            }

            DataView dv = dtClientes.DefaultView;
            dv.RowFilter = string.Format("nombreCompleto LIKE '%{0}%'", texto.Replace("'", "''"));

            if (dv.Count > 0)
            {
                listClientes.DataSource = dv;
                listClientes.DisplayMember = "nombreCompleto";
                listClientes.ValueMember = "idCliente";
                listClientes.Visible = true; // mostrar si hay resultados
            }
            else
            {
                listClientes.DataSource = null;
                listClientes.Visible = false; // ocultar si no hay coincidencias
            }
        }

        private void listClientes_Click(object sender, EventArgs e)
        {
            if (listClientes.SelectedIndex != -1)
            {
                idClienteSeleccionado = Convert.ToInt32(
                    ((DataRowView)listClientes.SelectedItem)["idCliente"]
                );

                // Mostrar el nombre en el TextBox
                txtBuscarCliente.Text = listClientes.Text;

                // Ocultar la lista
                listClientes.Visible = false;

                // 🔹 Cargar fotos de este cliente en el DataGridView
                CargarFotosCliente(idClienteSeleccionado);
            }
        }

        private void dgvFotos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // evitar cabecera
            {
                DataGridViewRow row = dgvFotos.Rows[e.RowIndex];

                if (row.Cells["Foto"].Value != null && row.Cells["Foto"].Value is Image)
                {
                    pictureBox1.Image = (Image)row.Cells["Foto"].Value;
                }
            }
        }


        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                    sfd.Title = "Guardar imagen";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        // 🔹 Clonar la imagen para evitar bloqueo de GDI+
                        using (Bitmap bmp = new Bitmap(pictureBox1.Image))
                        {
                            bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        }

                        MessageBox.Show("Imagen guardada correctamente");
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen en el PictureBox");
            }
        }
    }
}
