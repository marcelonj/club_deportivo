namespace ProyectoFinal
{
    partial class Vencimientos
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
            dtgvSocios = new System.Windows.Forms.DataGridView();
            btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).BeginInit();
            SuspendLayout();
            // 
            // dtgvSocios
            // 
            dtgvSocios.BackgroundColor = System.Drawing.Color.FromArgb(213, 229, 240);
            dtgvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvSocios.Location = new System.Drawing.Point(73, 50);
            dtgvSocios.Name = "dtgvSocios";
            dtgvSocios.RowHeadersWidth = 51;
            dtgvSocios.RowTemplate.Height = 25;
            dtgvSocios.Size = new System.Drawing.Size(654, 294);
            dtgvSocios.TabIndex = 7;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnVolver.Location = new System.Drawing.Point(652, 376);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new System.Drawing.Size(75, 25);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // Vencimientos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(153, 206, 213);
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dtgvSocios);
            Controls.Add(btnVolver);
            Name = "Vencimientos";
            Text = "Vencimientos";
            Load += Vencimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvSocios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvSocios;
        private System.Windows.Forms.Button btnVolver;
    }
}