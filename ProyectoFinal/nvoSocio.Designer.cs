namespace ProyectoFinal
{
    partial class nvoSocio
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
            lblNombre = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            lblApellido = new System.Windows.Forms.Label();
            lblGenero = new System.Windows.Forms.Label();
            txtEdad = new System.Windows.Forms.TextBox();
            lblEdad = new System.Windows.Forms.Label();
            txtDni = new System.Windows.Forms.TextBox();
            lblDni = new System.Windows.Forms.Label();
            cboGenero = new System.Windows.Forms.ComboBox();
            btnRegistrar = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(287, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(347, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(158, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(347, 109);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(158, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(287, 117);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Location = new System.Drawing.Point(293, 146);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new System.Drawing.Size(48, 15);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Genero:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new System.Drawing.Point(347, 167);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new System.Drawing.Size(158, 23);
            txtEdad.TabIndex = 7;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new System.Drawing.Point(305, 175);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new System.Drawing.Size(36, 15);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad:";
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(347, 196);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(158, 23);
            txtDni.TabIndex = 9;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new System.Drawing.Point(311, 204);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(30, 15);
            lblDni.TabIndex = 8;
            lblDni.Text = "DNI:";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new System.Drawing.Point(347, 138);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new System.Drawing.Size(158, 23);
            cboGenero.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new System.Drawing.Point(385, 269);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(75, 23);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new System.Drawing.Point(385, 298);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(75, 23);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // nvoSocio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(btnRegistrar);
            Controls.Add(cboGenero);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtEdad);
            Controls.Add(lblEdad);
            Controls.Add(lblGenero);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "nvoSocio";
            Text = "nvoSocio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnVolver;
    }
}