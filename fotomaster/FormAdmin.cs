using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fotomaster
{
    public partial class FormAdmin : Form
    {
        string conexion = "Server=127.0.0.1;Database=fotomaster;Uid=root;Pwd=;";
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btnregistrocliente_Click(object sender, EventArgs e)
        {
            FormRegistrocliente formcliente = new FormRegistrocliente();
            formcliente.Show();
            this.Hide();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }
    }
}
