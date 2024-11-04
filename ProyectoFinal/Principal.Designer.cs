namespace ProyectoFinal
{
    partial class Principal
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
            btnSalir = new System.Windows.Forms.Button();
            btnSocios = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnSalir.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSalir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnSalir.Location = new System.Drawing.Point(759, 441);
            btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(117, 49);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnSocios
            // 
            btnSocios.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnSocios.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSocios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnSocios.Location = new System.Drawing.Point(98, 108);
            btnSocios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSocios.Name = "btnSocios";
            btnSocios.Size = new System.Drawing.Size(173, 64);
            btnSocios.TabIndex = 1;
            btnSocios.Text = "Registrar Socio";
            btnSocios.UseVisualStyleBackColor = false;
            btnSocios.Click += btnSocios_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            button1.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button1.Location = new System.Drawing.Point(98, 180);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(173, 64);
            button1.TabIndex = 2;
            button1.Text = "Cobrar Cuota";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            button2.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button2.Location = new System.Drawing.Point(98, 252);
            button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(173, 64);
            button2.TabIndex = 3;
            button2.Text = "Registrar No Socio";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            button3.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            button3.Location = new System.Drawing.Point(98, 324);
            button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(173, 64);
            button3.TabIndex = 4;
            button3.Text = "Emitir Carnet";
            button3.UseVisualStyleBackColor = false;
            // 
            // Principal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(153, 206, 213);
            ClientSize = new System.Drawing.Size(914, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnSocios);
            Controls.Add(btnSalir);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Principal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}