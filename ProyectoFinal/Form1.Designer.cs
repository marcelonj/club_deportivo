namespace ProyectoFinal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUser = new System.Windows.Forms.TextBox();
            txtPass = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            lblUser = new System.Windows.Forms.Label();
            lblPass = new System.Windows.Forms.Label();
            lwchkShowHidePass = new System.Windows.Forms.CheckBox();
            imgUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgUser).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Font = new System.Drawing.Font("Futura Bk BT", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtUser.Location = new System.Drawing.Point(624, 157);
            txtUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(185, 19);
            txtUser.TabIndex = 0;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPass
            // 
            txtPass.Font = new System.Drawing.Font("Futura Bk BT", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPass.Location = new System.Drawing.Point(624, 203);
            txtPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(185, 19);
            txtPass.TabIndex = 1;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = System.Drawing.Color.FromArgb(90, 150, 191);
            btnLogin.Font = new System.Drawing.Font("Futura Bk BT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            btnLogin.Location = new System.Drawing.Point(664, 286);
            btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(97, 31);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new System.Drawing.Font("Futura BdCn BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblUser.Location = new System.Drawing.Point(554, 154);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(64, 21);
            lblUser.TabIndex = 3;
            lblUser.Text = "Usuario:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new System.Drawing.Font("Futura BdCn BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPass.Location = new System.Drawing.Point(528, 200);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(87, 21);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña:";
            // 
            // lwchkShowHidePass
            // 
            lwchkShowHidePass.AutoSize = true;
            lwchkShowHidePass.Font = new System.Drawing.Font("Futura BdCn BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lwchkShowHidePass.Location = new System.Drawing.Point(646, 248);
            lwchkShowHidePass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            lwchkShowHidePass.Name = "lwchkShowHidePass";
            lwchkShowHidePass.Size = new System.Drawing.Size(133, 22);
            lwchkShowHidePass.TabIndex = 5;
            lwchkShowHidePass.Text = "Mostrar contraseña";
            lwchkShowHidePass.UseVisualStyleBackColor = true;
            lwchkShowHidePass.CheckedChanged += lwchkShowHidePass_CheckedChanged;
            // 
            // imgUser
            // 
            imgUser.Image = (System.Drawing.Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new System.Drawing.Point(213, 122);
            imgUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            imgUser.Name = "imgUser";
            imgUser.Size = new System.Drawing.Size(196, 206);
            imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgUser.TabIndex = 6;
            imgUser.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(153, 206, 213);
            ClientSize = new System.Drawing.Size(1028, 600);
            Controls.Add(imgUser);
            Controls.Add(lwchkShowHidePass);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)imgUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.CheckBox lwchkShowHidePass;
        private System.Windows.Forms.PictureBox imgUser;
    }
}
