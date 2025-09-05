namespace fotomaster
{
    partial class FormAdmin
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
            this.btnregistrocliente = new System.Windows.Forms.Button();
            this.btnregistrousuario = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.btnclientefoto = new System.Windows.Forms.Button();
            this.btnservicios = new System.Windows.Forms.Button();
            this.btndetalleventa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnregistrocliente
            // 
            this.btnregistrocliente.Location = new System.Drawing.Point(29, 111);
            this.btnregistrocliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregistrocliente.Name = "btnregistrocliente";
            this.btnregistrocliente.Size = new System.Drawing.Size(212, 80);
            this.btnregistrocliente.TabIndex = 0;
            this.btnregistrocliente.Text = "Cliente";
            this.btnregistrocliente.UseVisualStyleBackColor = true;
            this.btnregistrocliente.Click += new System.EventHandler(this.btnregistrocliente_Click);
            // 
            // btnregistrousuario
            // 
            this.btnregistrousuario.Location = new System.Drawing.Point(29, 209);
            this.btnregistrousuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnregistrousuario.Name = "btnregistrousuario";
            this.btnregistrousuario.Size = new System.Drawing.Size(212, 86);
            this.btnregistrousuario.TabIndex = 3;
            this.btnregistrousuario.Text = "Usuarios";
            this.btnregistrousuario.UseVisualStyleBackColor = true;
            this.btnregistrousuario.Click += new System.EventHandler(this.btnregistrousuario_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(29, 15);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(113, 64);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnreportes
            // 
            this.btnreportes.Location = new System.Drawing.Point(29, 303);
            this.btnreportes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(212, 92);
            this.btnreportes.TabIndex = 5;
            this.btnreportes.Text = "Reportes";
            this.btnreportes.UseVisualStyleBackColor = true;
            this.btnreportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnventa
            // 
            this.btnventa.Location = new System.Drawing.Point(29, 402);
            this.btnventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(212, 91);
            this.btnventa.TabIndex = 6;
            this.btnventa.Text = "Venta";
            this.btnventa.UseVisualStyleBackColor = true;
            this.btnventa.Click += new System.EventHandler(this.btnventa_Click);
            // 
            // btnclientefoto
            // 
            this.btnclientefoto.Location = new System.Drawing.Point(29, 501);
            this.btnclientefoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclientefoto.Name = "btnclientefoto";
            this.btnclientefoto.Size = new System.Drawing.Size(212, 84);
            this.btnclientefoto.TabIndex = 7;
            this.btnclientefoto.Text = "Clientes Fotos";
            this.btnclientefoto.UseVisualStyleBackColor = true;
            this.btnclientefoto.Click += new System.EventHandler(this.btnclientefoto_Click);
            // 
            // btnservicios
            // 
            this.btnservicios.Location = new System.Drawing.Point(29, 592);
            this.btnservicios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnservicios.Name = "btnservicios";
            this.btnservicios.Size = new System.Drawing.Size(212, 84);
            this.btnservicios.TabIndex = 8;
            this.btnservicios.Text = "Servicios";
            this.btnservicios.UseVisualStyleBackColor = true;
            this.btnservicios.Click += new System.EventHandler(this.btnservicios_Click);
            // 
            // btndetalleventa
            // 
            this.btndetalleventa.Location = new System.Drawing.Point(29, 683);
            this.btndetalleventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndetalleventa.Name = "btndetalleventa";
            this.btndetalleventa.Size = new System.Drawing.Size(212, 90);
            this.btndetalleventa.TabIndex = 9;
            this.btndetalleventa.Text = "Detalle de venta";
            this.btndetalleventa.UseVisualStyleBackColor = true;
            this.btndetalleventa.Click += new System.EventHandler(this.btndetalleventa_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 815);
            this.Controls.Add(this.btndetalleventa);
            this.Controls.Add(this.btnservicios);
            this.Controls.Add(this.btnclientefoto);
            this.Controls.Add(this.btnventa);
            this.Controls.Add(this.btnreportes);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnregistrousuario);
            this.Controls.Add(this.btnregistrocliente);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregistrocliente;
        private System.Windows.Forms.Button btnregistrousuario;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button btnclientefoto;
        private System.Windows.Forms.Button btnservicios;
        private System.Windows.Forms.Button btndetalleventa;
    }
}