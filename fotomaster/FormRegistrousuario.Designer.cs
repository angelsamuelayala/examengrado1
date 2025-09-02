namespace fotomaster
{
    partial class FormRegistrousuario
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnvolver = new System.Windows.Forms.Button();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbEmpleado = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(166, 144);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(277, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(161, 200);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(282, 20);
            this.txtapellido.TabIndex = 1;
            // 
            // btnregistro
            // 
            this.btnregistro.Location = new System.Drawing.Point(129, 445);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(172, 66);
            this.btnregistro.TabIndex = 2;
            this.btnregistro.Text = "Registrar";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(334, 443);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(192, 70);
            this.btnbuscar.TabIndex = 3;
            this.btnbuscar.Text = "Busqueda";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(633, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(384, 319);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnvolver
            // 
            this.btnvolver.Location = new System.Drawing.Point(23, 39);
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Size = new System.Drawing.Size(121, 40);
            this.btnvolver.TabIndex = 5;
            this.btnvolver.Text = "Volver";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(166, 260);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(272, 20);
            this.txtusuario.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(161, 316);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(284, 20);
            this.txtpassword.TabIndex = 7;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(161, 380);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(88, 17);
            this.rbAdmin.TabIndex = 10;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Administrador";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbEmpleado
            // 
            this.rbEmpleado.AutoSize = true;
            this.rbEmpleado.Location = new System.Drawing.Point(285, 380);
            this.rbEmpleado.Name = "rbEmpleado";
            this.rbEmpleado.Size = new System.Drawing.Size(72, 17);
            this.rbEmpleado.TabIndex = 11;
            this.rbEmpleado.TabStop = true;
            this.rbEmpleado.Text = "Empleado";
            this.rbEmpleado.UseVisualStyleBackColor = true;
            // 
            // FormRegistrousuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 637);
            this.Controls.Add(this.rbEmpleado);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.txtnombre);
            this.Name = "FormRegistrousuario";
            this.Text = "FormRegistrousuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnvolver;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbEmpleado;
    }
}