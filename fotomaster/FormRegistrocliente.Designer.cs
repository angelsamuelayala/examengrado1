namespace fotomaster
{
    partial class FormRegistrocliente
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
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.btnregistro = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnvolver = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(183, 131);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(272, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(183, 210);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(264, 20);
            this.txtapellido.TabIndex = 1;
            // 
            // btnregistro
            // 
            this.btnregistro.Location = new System.Drawing.Point(146, 363);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(144, 62);
            this.btnregistro.TabIndex = 2;
            this.btnregistro.Text = "Registrar";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(378, 370);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(161, 55);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(27, 22);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(102, 52);
            this.btnvolver.TabIndex = 4;
            this.btnvolver.Text = "volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(678, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 391);
            this.dataGridView1.TabIndex = 5;
            // 
            // FormRegistrocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 647);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Name = "FormRegistrocliente";
            this.Text = "FormRegistrocliente";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}