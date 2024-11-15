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
            groupBox1 = new System.Windows.Forms.GroupBox();
            optNoSocio = new System.Windows.Forms.RadioButton();
            optSocio = new System.Windows.Forms.RadioButton();
            cboApto = new System.Windows.Forms.ComboBox();
            lblApto = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNombre.Location = new System.Drawing.Point(183, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(55, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(246, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(158, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(246, 126);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(158, 23);
            txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblApellido.Location = new System.Drawing.Point(180, 130);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(54, 15);
            lblApellido.TabIndex = 2;
            lblApellido.Text = "Apellido:";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGenero.Location = new System.Drawing.Point(187, 159);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new System.Drawing.Size(51, 15);
            lblGenero.TabIndex = 4;
            lblGenero.Text = "Genero:";
            // 
            // txtEdad
            // 
            txtEdad.Location = new System.Drawing.Point(246, 184);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new System.Drawing.Size(158, 23);
            txtEdad.TabIndex = 7;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEdad.Location = new System.Drawing.Point(196, 188);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new System.Drawing.Size(39, 15);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Edad:";
            // 
            // txtDni
            // 
            txtDni.Location = new System.Drawing.Point(246, 213);
            txtDni.Name = "txtDni";
            txtDni.Size = new System.Drawing.Size(158, 23);
            txtDni.TabIndex = 9;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDni.Location = new System.Drawing.Point(203, 217);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(31, 15);
            lblDni.TabIndex = 8;
            lblDni.Text = "DNI:";
            // 
            // cboGenero
            // 
            cboGenero.FormattingEnabled = true;
            cboGenero.Location = new System.Drawing.Point(246, 155);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new System.Drawing.Size(158, 23);
            cboGenero.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnRegistrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            btnRegistrar.Location = new System.Drawing.Point(395, 301);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new System.Drawing.Size(75, 23);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnVolver.Location = new System.Drawing.Point(395, 330);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(75, 23);
            btnVolver.TabIndex = 12;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(optNoSocio);
            groupBox1.Controls.Add(optSocio);
            groupBox1.Location = new System.Drawing.Point(529, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(176, 87);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Condición";
            // 
            // optNoSocio
            // 
            optNoSocio.AutoSize = true;
            optNoSocio.Location = new System.Drawing.Point(21, 51);
            optNoSocio.Name = "optNoSocio";
            optNoSocio.Size = new System.Drawing.Size(72, 19);
            optNoSocio.TabIndex = 1;
            optNoSocio.TabStop = true;
            optNoSocio.Text = "No socio";
            optNoSocio.UseVisualStyleBackColor = true;
            // 
            // optSocio
            // 
            optSocio.AutoSize = true;
            optSocio.Location = new System.Drawing.Point(21, 22);
            optSocio.Name = "optSocio";
            optSocio.Size = new System.Drawing.Size(54, 19);
            optSocio.TabIndex = 0;
            optSocio.TabStop = true;
            optSocio.Text = "Socio";
            optSocio.UseVisualStyleBackColor = true;
            // 
            // cboApto
            // 
            cboApto.FormattingEnabled = true;
            cboApto.Location = new System.Drawing.Point(246, 242);
            cboApto.Name = "cboApto";
            cboApto.Size = new System.Drawing.Size(158, 23);
            cboApto.TabIndex = 15;
            // 
            // lblApto
            // 
            lblApto.AutoSize = true;
            lblApto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblApto.Location = new System.Drawing.Point(175, 244);
            lblApto.Name = "lblApto";
            lblApto.Size = new System.Drawing.Size(65, 15);
            lblApto.TabIndex = 14;
            lblApto.Text = "Apto físico:";
            // 
            // nvoSocio
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(153, 206, 213);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cboApto);
            Controls.Add(lblApto);
            Controls.Add(groupBox1);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optNoSocio;
        private System.Windows.Forms.RadioButton optSocio;
        private System.Windows.Forms.ComboBox cboApto;
        private System.Windows.Forms.Label lblApto;
    }
}