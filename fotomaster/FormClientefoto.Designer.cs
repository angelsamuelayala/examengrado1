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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFotos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pictureBox1.Location = new System.Drawing.Point(1142, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 393);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FormClientefoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 566);
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
    }
}