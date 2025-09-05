namespace fotomaster
{
    partial class FormClientefoto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFotos = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.btnvolver = new System.Windows.Forms.Button();
            this.btndescargar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscarPorFoto = new System.Windows.Forms.Button();
            this.BtnCargarFoto = new System.Windows.Forms.Button();
            this.BtnIndexarEmbeddings = new System.Windows.Forms.Button();
            this.pictureBoxConsulta = new System.Windows.Forms.PictureBox();
            this.btnTestSelf = new System.Windows.Forms.Button();
            this.btnCheckEmbeddings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFotos
            // 
            this.dgvFotos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFotos.Location = new System.Drawing.Point(632, 74);
            this.dgvFotos.Name = "dgvFotos";
            this.dgvFotos.Size = new System.Drawing.Size(372, 392);
            this.dgvFotos.TabIndex = 0;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(122, 95);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(294, 20);
            this.txtBuscarCliente.TabIndex = 1;
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(122, 121);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(294, 82);
            this.listClientes.TabIndex = 2;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(12, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(111, 51);
            this.btnvolver.TabIndex = 3;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btndescargar
            // 
            this.btndescargar.Location = new System.Drawing.Point(1342, 478);
            this.btndescargar.Name = "btndescargar";
            this.btndescargar.Size = new System.Drawing.Size(166, 76);
            this.btndescargar.TabIndex = 4;
            this.btndescargar.Text = "Descargar";
            this.btndescargar.UseVisualStyleBackColor = true;
            this.btndescargar.Click += new System.EventHandler(this.btndescargar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(545, 74);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(81, 61);
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1368, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscarPorFoto
            // 
            this.btnBuscarPorFoto.Location = new System.Drawing.Point(86, 627);
            this.btnBuscarPorFoto.Name = "btnBuscarPorFoto";
            this.btnBuscarPorFoto.Size = new System.Drawing.Size(188, 56);
            this.btnBuscarPorFoto.TabIndex = 7;
            this.btnBuscarPorFoto.Text = "BuscarPorFoto";
            this.btnBuscarPorFoto.UseVisualStyleBackColor = true;
            this.btnBuscarPorFoto.Click += new System.EventHandler(this.btnBuscarPorFoto_Click);
            // 
            // BtnCargarFoto
            // 
            this.BtnCargarFoto.Location = new System.Drawing.Point(50, 490);
            this.BtnCargarFoto.Name = "BtnCargarFoto";
            this.BtnCargarFoto.Size = new System.Drawing.Size(168, 52);
            this.BtnCargarFoto.TabIndex = 8;
            this.BtnCargarFoto.Text = "CargarFoto";
            this.BtnCargarFoto.UseVisualStyleBackColor = true;
            // 
            // BtnIndexarEmbeddings
            // 
            this.BtnIndexarEmbeddings.Location = new System.Drawing.Point(357, 627);
            this.BtnIndexarEmbeddings.Name = "BtnIndexarEmbeddings";
            this.BtnIndexarEmbeddings.Size = new System.Drawing.Size(202, 45);
            this.BtnIndexarEmbeddings.TabIndex = 9;
            this.BtnIndexarEmbeddings.Text = "BtnIndexarEmbeddings";
            this.BtnIndexarEmbeddings.UseVisualStyleBackColor = true;
            this.BtnIndexarEmbeddings.Click += new System.EventHandler(this.BtnIndexarEmbeddings_Click_1);
            // 
            // pictureBoxConsulta
            // 
            this.pictureBoxConsulta.Location = new System.Drawing.Point(1035, 121);
            this.pictureBoxConsulta.Name = "pictureBoxConsulta";
            this.pictureBoxConsulta.Size = new System.Drawing.Size(306, 309);
            this.pictureBoxConsulta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConsulta.TabIndex = 10;
            this.pictureBoxConsulta.TabStop = false;
            // 
            // btnTestSelf
            // 
            this.btnTestSelf.Location = new System.Drawing.Point(665, 600);
            this.btnTestSelf.Name = "btnTestSelf";
            this.btnTestSelf.Size = new System.Drawing.Size(190, 34);
            this.btnTestSelf.TabIndex = 11;
            this.btnTestSelf.Text = " btnTestSelf";
            this.btnTestSelf.UseVisualStyleBackColor = true;
            this.btnTestSelf.Click += new System.EventHandler(this.btnTestSelf_Click);
            // 
            // btnCheckEmbeddings
            // 
            this.btnCheckEmbeddings.Location = new System.Drawing.Point(922, 584);
            this.btnCheckEmbeddings.Name = "btnCheckEmbeddings";
            this.btnCheckEmbeddings.Size = new System.Drawing.Size(181, 33);
            this.btnCheckEmbeddings.TabIndex = 12;
            this.btnCheckEmbeddings.Text = "btnCheckEmbedding";
            this.btnCheckEmbeddings.UseVisualStyleBackColor = true;
            this.btnCheckEmbeddings.Click += new System.EventHandler(this.btnCheckEmbeddings_Click);
            // 
            // FormClientefoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 726);
            this.Controls.Add(this.btnCheckEmbeddings);
            this.Controls.Add(this.btnTestSelf);
            this.Controls.Add(this.pictureBoxConsulta);
            this.Controls.Add(this.BtnIndexarEmbeddings);
            this.Controls.Add(this.BtnCargarFoto);
            this.Controls.Add(this.btnBuscarPorFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.btndescargar);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.dgvFotos);
            this.Name = "FormClientefoto";
            this.Text = "FormClientefoto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFotos;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.Button btndescargar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarPorFoto;
        private System.Windows.Forms.Button BtnCargarFoto;
        private System.Windows.Forms.Button BtnIndexarEmbeddings;
        private System.Windows.Forms.PictureBox pictureBoxConsulta;
        private System.Windows.Forms.Button btnTestSelf;
        private System.Windows.Forms.Button btnCheckEmbeddings;
    }
}