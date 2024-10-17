namespace ProyectoFinal
{
    partial class Socios
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
            components = new System.ComponentModel.Container();
            btnAgregarSocio = new System.Windows.Forms.Button();
            btnVolver = new System.Windows.Forms.Button();
            conexionBindingSource = new System.Windows.Forms.BindingSource(components);
            dtgvSocios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarSocio
            // 
            btnAgregarSocio.Location = new System.Drawing.Point(536, 356);
            btnAgregarSocio.Name = "btnAgregarSocio";
            btnAgregarSocio.Size = new System.Drawing.Size(109, 25);
            btnAgregarSocio.TabIndex = 0;
            btnAgregarSocio.Text = "Agregar socio";
            btnAgregarSocio.UseVisualStyleBackColor = true;
            btnAgregarSocio.Click += btnAgregarSocio_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new System.Drawing.Point(651, 356);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(75, 25);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // dtgvSocios
            // 
            dtgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Location = new System.Drawing.Point(72, 30);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.RowTemplate.Height = 25;
            dtgvSocios.Size = new System.Drawing.Size(654, 294);
            dtgvSocios.TabIndex = 2;
            // 
            // Socios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dtgvSocios);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregarSocio);
            Name = "Socios";
            Text = "Socios";
            Load += Socios_Load;
            ((System.ComponentModel.ISupportInitialize)conexionBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnAgregarSocio;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource conexionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNroSocio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridView dtgvSocios;
    }
}