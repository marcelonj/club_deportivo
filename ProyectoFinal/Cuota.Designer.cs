namespace ProyectoFinal
{
    partial class Cuota
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblApellidoDato = new System.Windows.Forms.Label();
            lblNombreDato = new System.Windows.Forms.Label();
            lblDniDato = new System.Windows.Forms.Label();
            lblNroSocioDato = new System.Windows.Forms.Label();
            lblApellido = new System.Windows.Forms.Label();
            lblNombre = new System.Windows.Forms.Label();
            lblDni = new System.Windows.Forms.Label();
            lblNroSocio = new System.Windows.Forms.Label();
            btnCuota = new System.Windows.Forms.Button();
            txtDocumento = new System.Windows.Forms.TextBox();
            lblDoc = new System.Windows.Forms.Label();
            btnVolver = new System.Windows.Forms.Button();
            txtMonto = new System.Windows.Forms.TextBox();
            lblMonto = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            groupBox1.Location = new System.Drawing.Point(371, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(388, 148);
            groupBox1.TabIndex = 12;
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
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new System.Drawing.Point(60, 113);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new System.Drawing.Size(54, 15);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
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
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new System.Drawing.Point(84, 61);
            lblDni.Name = "lblDni";
            lblDni.Size = new System.Drawing.Size(30, 15);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
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
            // btnCuota
            // 
            btnCuota.BackColor = System.Drawing.Color.FromArgb(255, 192, 128);
            btnCuota.Enabled = false;
            btnCuota.Location = new System.Drawing.Point(178, 174);
            btnCuota.Name = "btnCuota";
            btnCuota.Size = new System.Drawing.Size(102, 37);
            btnCuota.TabIndex = 11;
            btnCuota.Text = "Pagar cuota";
            btnCuota.UseVisualStyleBackColor = false;
            btnCuota.Click += btnCuota_Click;
            // 
            // txtDocumento
            // 
            txtDocumento.Location = new System.Drawing.Point(133, 95);
            txtDocumento.Name = "txtDocumento";
            txtDocumento.Size = new System.Drawing.Size(188, 23);
            txtDocumento.TabIndex = 10;
            txtDocumento.TextChanged += txtDocumento_TextChanged;
            // 
            // lblDoc
            // 
            lblDoc.AutoSize = true;
            lblDoc.Enabled = false;
            lblDoc.Location = new System.Drawing.Point(54, 98);
            lblDoc.Name = "lblDoc";
            lblDoc.Size = new System.Drawing.Size(73, 15);
            lblDoc.TabIndex = 9;
            lblDoc.Text = "Documento:";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnVolver.Location = new System.Drawing.Point(633, 357);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(102, 37);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new System.Drawing.Point(133, 133);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new System.Drawing.Size(188, 23);
            txtMonto.TabIndex = 15;
            txtMonto.TextChanged += txtDocumento_TextChanged;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Enabled = false;
            lblMonto.Location = new System.Drawing.Point(81, 136);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new System.Drawing.Size(46, 15);
            lblMonto.TabIndex = 14;
            lblMonto.Text = "Monto:";
            // 
            // Cuota
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(153, 206, 213);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(txtMonto);
            Controls.Add(lblMonto);
            Controls.Add(btnVolver);
            Controls.Add(groupBox1);
            Controls.Add(btnCuota);
            Controls.Add(txtDocumento);
            Controls.Add(lblDoc);
            Name = "Cuota";
            Text = "Cuota";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblApellidoDato;
        private System.Windows.Forms.Label lblNombreDato;
        private System.Windows.Forms.Label lblDniDato;
        private System.Windows.Forms.Label lblNroSocioDato;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNroSocio;
        private System.Windows.Forms.Button btnCuota;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
    }
}