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
            txtUser.Location = new System.Drawing.Point(373, 146);
            txtUser.Name = "txtUser";
            txtUser.Size = new System.Drawing.Size(100, 23);
            txtUser.TabIndex = 0;
            txtUser.Text = "USUARIO";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new System.Drawing.Point(373, 209);
            txtPass.Name = "txtPass";
            txtPass.Size = new System.Drawing.Size(100, 23);
            txtPass.TabIndex = 1;
            txtPass.Text = "CONTRASEÑA";
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Location = new System.Drawing.Point(386, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(75, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "INGRESAR";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new System.Drawing.Point(317, 154);
            lblUser.Name = "lblUser";
            lblUser.Size = new System.Drawing.Size(50, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "Usuario:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new System.Drawing.Point(297, 217);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(70, 15);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña:";
            // 
            // lwchkShowHidePass
            // 
            lwchkShowHidePass.AutoSize = true;
            lwchkShowHidePass.Location = new System.Drawing.Point(489, 216);
            lwchkShowHidePass.Name = "lwchkShowHidePass";
            lwchkShowHidePass.Size = new System.Drawing.Size(128, 19);
            lwchkShowHidePass.TabIndex = 5;
            lwchkShowHidePass.Text = "Mostrar contraseña";
            lwchkShowHidePass.UseVisualStyleBackColor = true;
            lwchkShowHidePass.CheckedChanged += lwchkShowHidePass_CheckedChanged;
            // 
            // imgUser
            // 
            imgUser.Image = (System.Drawing.Image)resources.GetObject("imgUser.Image");
            imgUser.Location = new System.Drawing.Point(27, 25);
            imgUser.Name = "imgUser";
            imgUser.Size = new System.Drawing.Size(175, 175);
            imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            imgUser.TabIndex = 6;
            imgUser.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(imgUser);
            Controls.Add(lwchkShowHidePass);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
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
