
namespace ShopApp
{
    partial class frmLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRules = new System.Windows.Forms.Label();
            this.lblForgot = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pbShowHidePass = new System.Windows.Forms.PictureBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picENG = new System.Windows.Forms.PictureBox();
            this.picVN = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHidePass)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picENG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVN)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblRules);
            this.panel1.Controls.Add(this.lblForgot);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pbShowHidePass);
            this.panel1.Controls.Add(this.lblPass);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Location = new System.Drawing.Point(677, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 300);
            this.panel1.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPass.Location = new System.Drawing.Point(50, 144);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(165, 23);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtUsername.Location = new System.Drawing.Point(50, 83);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 30);
            this.txtUsername.TabIndex = 5;
            // 
            // lblRules
            // 
            this.lblRules.AutoSize = true;
            this.lblRules.ForeColor = System.Drawing.Color.Red;
            this.lblRules.Location = new System.Drawing.Point(204, 254);
            this.lblRules.Name = "lblRules";
            this.lblRules.Size = new System.Drawing.Size(60, 13);
            this.lblRules.TabIndex = 4;
            this.lblRules.Text = "Rules shop";
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.ForeColor = System.Drawing.Color.Red;
            this.lblForgot.Location = new System.Drawing.Point(31, 254);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(91, 13);
            this.lblForgot.TabIndex = 4;
            this.lblForgot.Text = "Forgot password?";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(34, 196);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(230, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "L O G I N";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pbShowHidePass
            // 
            this.pbShowHidePass.BackColor = System.Drawing.Color.White;
            this.pbShowHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbShowHidePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbShowHidePass.Image = global::ShopApp.Properties.Resources.eye_slash_solid;
            this.pbShowHidePass.Location = new System.Drawing.Point(221, 136);
            this.pbShowHidePass.Name = "pbShowHidePass";
            this.pbShowHidePass.Size = new System.Drawing.Size(43, 40);
            this.pbShowHidePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShowHidePass.TabIndex = 2;
            this.pbShowHidePass.TabStop = false;
            this.pbShowHidePass.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblPass
            // 
            this.lblPass.BackColor = System.Drawing.Color.White;
            this.lblPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPass.Location = new System.Drawing.Point(34, 136);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(230, 40);
            this.lblPass.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsername.Location = new System.Drawing.Point(34, 75);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(230, 40);
            this.lblUsername.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLogin.Location = new System.Drawing.Point(28, 19);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(157, 31);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "         Login";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.picENG);
            this.panel2.Controls.Add(this.picVN);
            this.panel2.Location = new System.Drawing.Point(15, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 84);
            this.panel2.TabIndex = 2;
            // 
            // picENG
            // 
            this.picENG.BackgroundImage = global::ShopApp.Properties.Resources.englishFlag;
            this.picENG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picENG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picENG.Location = new System.Drawing.Point(128, 6);
            this.picENG.Name = "picENG";
            this.picENG.Size = new System.Drawing.Size(120, 70);
            this.picENG.TabIndex = 0;
            this.picENG.TabStop = false;
            this.picENG.Click += new System.EventHandler(this.picENG_Click);
            // 
            // picVN
            // 
            this.picVN.BackgroundImage = global::ShopApp.Properties.Resources.vietnameseFlag;
            this.picVN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVN.Location = new System.Drawing.Point(3, 6);
            this.picVN.Name = "picVN";
            this.picVN.Size = new System.Drawing.Size(120, 70);
            this.picVN.TabIndex = 0;
            this.picVN.TabStop = false;
            this.picVN.Click += new System.EventHandler(this.picVN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(881, 647);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Meyou Shop App";
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::ShopApp.Properties.Resources.backgroundMain;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1000, 667);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowHidePass)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picENG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRules;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picVN;
        private System.Windows.Forms.PictureBox picENG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox pbShowHidePass;
    }
}

