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
            btnAgregarSocio.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnAgregarSocio.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnAgregarSocio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnAgregarSocio.Location = new System.Drawing.Point(613, 475);
            btnAgregarSocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAgregarSocio.Name = "btnAgregarSocio";
            btnAgregarSocio.Size = new System.Drawing.Size(125, 33);
            btnAgregarSocio.TabIndex = 0;
            btnAgregarSocio.Text = "Agregar socio";
            btnAgregarSocio.UseVisualStyleBackColor = false;
            btnAgregarSocio.Click += btnAgregarSocio_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnVolver.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnVolver.Location = new System.Drawing.Point(744, 475);
            btnVolver.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(86, 33);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // conexionBindingSource
            // 
            conexionBindingSource.DataSource = typeof(Datos.Conexion);
            // 
            // dtgvSocios
            // 
            dtgvSocios.BackgroundColor = System.Drawing.Color.FromArgb(213, 229, 240);
            dtgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Location = new System.Drawing.Point(82, 40);
            dtgvSocios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.RowHeadersWidth = 51;
            dtgvSocios.RowTemplate.Height = 25;
            dtgvSocios.Size = new System.Drawing.Size(747, 392);
            dtgvSocios.TabIndex = 2;
            // 
            // Socios
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(153, 206, 213);
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(dtgvSocios);
            Controls.Add(btnVolver);
            Controls.Add(btnAgregarSocio);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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