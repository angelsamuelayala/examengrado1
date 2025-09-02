namespace fotomaster
{
    partial class FormVenta
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
            this.btnvolver = new System.Windows.Forms.Button();
            this.cbFormato = new System.Windows.Forms.ComboBox();
            this.cbCalidad = new System.Windows.Forms.ComboBox();
            this.btnventa = new System.Windows.Forms.Button();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnCargarFoto = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvDetallesVenta = new System.Windows.Forms.DataGridView();
            this.cbServicio = new System.Windows.Forms.ComboBox();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.listClientes = new System.Windows.Forms.ListBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(12, 12);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(116, 58);
            this.btnvolver.TabIndex = 0;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // cbFormato
            // 
            this.cbFormato.FormattingEnabled = true;
            this.cbFormato.Location = new System.Drawing.Point(128, 307);
            this.cbFormato.Name = "cbFormato";
            this.cbFormato.Size = new System.Drawing.Size(142, 21);
            this.cbFormato.TabIndex = 3;
            // 
            // cbCalidad
            // 
            this.cbCalidad.FormattingEnabled = true;
            this.cbCalidad.Location = new System.Drawing.Point(341, 307);
            this.cbCalidad.Name = "cbCalidad";
            this.cbCalidad.Size = new System.Drawing.Size(151, 21);
            this.cbCalidad.TabIndex = 4;
            // 
            // btnventa
            // 
            this.btnventa.Location = new System.Drawing.Point(1256, 539);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(172, 57);
            this.btnventa.TabIndex = 7;
            this.btnventa.Text = "Vender";
            this.btnventa.UseVisualStyleBackColor = true;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(1031, 52);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(397, 398);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 8;
            this.pictureBoxFoto.TabStop = false;
            // 
            // btnCargarFoto
            // 
            this.btnCargarFoto.Location = new System.Drawing.Point(1284, 456);
            this.btnCargarFoto.Name = "btnCargarFoto";
            this.btnCargarFoto.Size = new System.Drawing.Size(144, 37);
            this.btnCargarFoto.TabIndex = 9;
            this.btnCargarFoto.Text = "Cargar Foto";
            this.btnCargarFoto.UseVisualStyleBackColor = true;
            this.btnCargarFoto.Click += new System.EventHandler(this.btnCargarFoto_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(158, 434);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(182, 60);
            this.btnregistrar.TabIndex = 10;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(128, 378);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(136, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // dgvDetallesVenta
            // 
            this.dgvDetallesVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetallesVenta.Location = new System.Drawing.Point(223, 591);
            this.dgvDetallesVenta.Name = "dgvDetallesVenta";
            this.dgvDetallesVenta.Size = new System.Drawing.Size(872, 106);
            this.dgvDetallesVenta.TabIndex = 12;
            // 
            // cbServicio
            // 
            this.cbServicio.FormattingEnabled = true;
            this.cbServicio.Location = new System.Drawing.Point(559, 307);
            this.cbServicio.Name = "cbServicio";
            this.cbServicio.Size = new System.Drawing.Size(126, 21);
            this.cbServicio.TabIndex = 13;
            // 
            // cbTiempo
            // 
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.Location = new System.Drawing.Point(759, 307);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(165, 21);
            this.cbTiempo.TabIndex = 14;
            // 
            // listClientes
            // 
            this.listClientes.FormattingEnabled = true;
            this.listClientes.Location = new System.Drawing.Point(209, 93);
            this.listClientes.Name = "listClientes";
            this.listClientes.Size = new System.Drawing.Size(259, 30);
            this.listClientes.TabIndex = 16;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Location = new System.Drawing.Point(209, 67);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(259, 20);
            this.txtBuscarCliente.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Formato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "calidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "tiempo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "nombre";
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 748);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.listClientes);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.cbServicio);
            this.Controls.Add(this.dgvDetallesVenta);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.btnCargarFoto);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.btnventa);
            this.Controls.Add(this.cbCalidad);
            this.Controls.Add(this.cbFormato);
            this.Controls.Add(this.btnvolver);
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetallesVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.ComboBox cbFormato;
        private System.Windows.Forms.ComboBox cbCalidad;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button btnCargarFoto;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvDetallesVenta;
        private System.Windows.Forms.ComboBox cbServicio;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.ListBox listClientes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}