namespace ProyectoFinal
{
    partial class Carnet
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
            lblDoc = new System.Windows.Forms.Label();
            txtDocumento = new System.Windows.Forms.TextBox();
            btnVolver = new System.Windows.Forms.Button();
            btnEmitir = new System.Windows.Forms.Button();
            lblNroSocio = new System.Windows.Forms.Label();
            lblDni = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblApellidoDato = new System.Windows.Forms.Label();
            lblNombreDato = new System.Windows.Forms.Label();
            lblDniDato = new System.Windows.Forms.Label();
            lblNroSocioDato = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Enabled = false;
            lblDoc.Location = new System.Drawing.Point(83, 79);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new System.Drawing.Size(73, 15);
            lblDoc.TabIndex = 0;
            lblDoc.Text = "Documento:";
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(162, 76);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(188, 23);
            txtDocumento.TabIndex = 1;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnVolver.Location = new System.Drawing.Point(645, 348);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(102, 37);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += button1_Click;
            // 
            // btnEmitir
            // 
            btnEmitir.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            btnEmitir.Enabled = false;
            btnEmitir.Location = new System.Drawing.Point(205, 128);
            btnEmitir.Name = "btnEmitir";
            btnEmitir.Size = new System.Drawing.Size(102, 37);
            btnEmitir.TabIndex = 3;
            btnEmitir.Text = "Emitir carnet";
            btnEmitir.UseVisualStyleBackColor = false;
            btnEmitir.Click += btnEmitir_Click;
            // 
            // lblNroSocio
            // 
            lblNroSocio.AutoSize = true;
            lblNroSocio.Location = new System.Drawing.Point(13, 34);
            lblNroSocio.Name = "lblNroSocio";
            lblNroSocio.Size = new System.Drawing.Size(101, 15);
            lblNroSocio.TabIndex = 4;
            lblNroSocio.Text = "Número de socio:";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new System.Drawing.Point(84, 61);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(30, 15);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new System.Drawing.Point(60, 86);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new System.Drawing.Size(54, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(60, 113);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(54, 15);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblApellidoDato);
            groupBox1.Controls.Add(lblNombreDato);
            groupBox1.Controls.Add(lblDniDato);
            groupBox1.Controls.Add(lblNroSocioDato);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblDni);
            groupBox1.Controls.Add(lblNroSocio);
            groupBox1.Location = new System.Drawing.Point(400, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(388, 148);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del socio";
            // 
            // lblApellidoDato
            // 
            lblApellidoDato.AutoSize = true;
            lblApellidoDato.Location = new System.Drawing.Point(120, 113);
            lblApellidoDato.Name = "lblApellidoDato";
            lblApellidoDato.Size = new System.Drawing.Size(12, 15);
            lblApellidoDato.TabIndex = 11;
            lblApellidoDato.Text = "-";
            // 
            // lblNombreDato
            // 
            lblNombreDato.AutoSize = true;
            lblNombreDato.Location = new System.Drawing.Point(120, 86);
            lblNombreDato.Name = "lblNombreDato";
            lblNombreDato.Size = new System.Drawing.Size(12, 15);
            lblNombreDato.TabIndex = 10;
            lblNombreDato.Text = "-";
            // 
            // lblDniDato
            // 
            lblDniDato.AutoSize = true;
            lblDniDato.Location = new System.Drawing.Point(120, 61);
            lblDniDato.Name = "lblDniDato";
            lblDniDato.Size = new System.Drawing.Size(12, 15);
            lblDniDato.TabIndex = 9;
            lblDniDato.Text = "-";
            // 
            // lblNroSocioDato
            // 
            lblNroSocioDato.AutoSize = true;
            lblNroSocioDato.Location = new System.Drawing.Point(120, 34);
            lblNroSocioDato.Name = "lblNroSocioDato";
            lblNroSocioDato.Size = new System.Drawing.Size(12, 15);
            lblNroSocioDato.TabIndex = 8;
            lblNroSocioDato.Text = "-";
            // 
            // Carnet
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(153, 206, 213);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnEmitir);
            Controls.Add(btnVolver);
            Controls.Add(txtDocumento);
            Controls.Add(lblDoc);
            Name = "Carnet";
            Text = "Carnet";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnEmitir;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNroSocioDato;
        private System.Windows.Forms.Label lblApellidoDato;
        private System.Windows.Forms.Label lblNombreDato;
        private System.Windows.Forms.Label lblDniDato;
    }
}