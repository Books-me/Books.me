namespace Books.me
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.clearLabel = new System.Windows.Forms.Label();
            this.waringLabel = new System.Windows.Forms.Label();
            this.switchLabel = new System.Windows.Forms.Label();
            this.backToSignIn = new System.Windows.Forms.Label();
            this.hidePassword = new System.Windows.Forms.PictureBox();
            this.showPass = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.passIcon = new System.Windows.Forms.PictureBox();
            this.profileIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(499, 431);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(250, 34);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "SIGN IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Visible = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.txtUsername.Location = new System.Drawing.Point(530, 261);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 29);
            this.txtUsername.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Header);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 600);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your personal book organizer is waiting for you";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Header
            // 
            this.Header.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(40, 244);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(266, 43);
            this.Header.TabIndex = 0;
            this.Header.Text = "Glad to see you!";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Header.Click += new System.EventHandler(this.Header_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.panel2.Location = new System.Drawing.Point(499, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 1);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.panel3.Location = new System.Drawing.Point(499, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 1);
            this.panel3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(499, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 104);
            this.label2.TabIndex = 2;
            this.label2.Text = "WELCOME TO BOOKS.ME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(499, 431);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(250, 34);
            this.registerButton.TabIndex = 9;
            this.registerButton.Text = "SIGN UP";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.txtPass.Location = new System.Drawing.Point(530, 334);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(219, 19);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // clearLabel
            // 
            this.clearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.clearLabel.Location = new System.Drawing.Point(696, 368);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(53, 23);
            this.clearLabel.TabIndex = 11;
            this.clearLabel.Text = "Clear";
            this.clearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearLabel.Click += new System.EventHandler(this.clearLabel_Click);
            // 
            // waringLabel
            // 
            this.waringLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waringLabel.ForeColor = System.Drawing.Color.Red;
            this.waringLabel.Location = new System.Drawing.Point(527, 206);
            this.waringLabel.Name = "waringLabel";
            this.waringLabel.Size = new System.Drawing.Size(186, 44);
            this.waringLabel.TabIndex = 12;
            this.waringLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switchLabel
            // 
            this.switchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.switchLabel.Location = new System.Drawing.Point(499, 468);
            this.switchLabel.Name = "switchLabel";
            this.switchLabel.Size = new System.Drawing.Size(250, 36);
            this.switchLabel.TabIndex = 13;
            this.switchLabel.Text = "Already have an account? \r\nSign in here";
            this.switchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.switchLabel.Click += new System.EventHandler(this.switchLabel_Click);
            // 
            // backToSignIn
            // 
            this.backToSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(46)))));
            this.backToSignIn.Location = new System.Drawing.Point(536, 468);
            this.backToSignIn.Name = "backToSignIn";
            this.backToSignIn.Size = new System.Drawing.Size(163, 36);
            this.backToSignIn.TabIndex = 15;
            this.backToSignIn.Text = " ← Back to Sign Up";
            this.backToSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backToSignIn.Visible = false;
            this.backToSignIn.Click += new System.EventHandler(this.backToSignIn_Click);
            // 
            // hidePassword
            // 
            this.hidePassword.ImageLocation = "S:\\Books.me\\Project\\Books.me\\Books.me\\Content\\LoginForm\\Hidden.png";
            this.hidePassword.Location = new System.Drawing.Point(724, 333);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.Size = new System.Drawing.Size(25, 25);
            this.hidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePassword.TabIndex = 16;
            this.hidePassword.TabStop = false;
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click);
            // 
            // showPass
            // 
            this.showPass.Image = global::Books.me.Properties.Resources.Visible;
            this.showPass.Location = new System.Drawing.Point(724, 333);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(25, 25);
            this.showPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPass.TabIndex = 17;
            this.showPass.TabStop = false;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageLocation = "S:\\Books.me\\Project\\Books.me\\Books.me\\Content\\LoginForm\\Close.png";
            this.btnClose.Location = new System.Drawing.Point(873, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 14;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // passIcon
            // 
            this.passIcon.Image = ((System.Drawing.Image)(resources.GetObject("passIcon.Image")));
            this.passIcon.Location = new System.Drawing.Point(499, 333);
            this.passIcon.Name = "passIcon";
            this.passIcon.Size = new System.Drawing.Size(25, 25);
            this.passIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passIcon.TabIndex = 7;
            this.passIcon.TabStop = false;
            // 
            // profileIcon
            // 
            this.profileIcon.Image = global::Books.me.Properties.Resources.User;
            this.profileIcon.Location = new System.Drawing.Point(499, 261);
            this.profileIcon.Name = "profileIcon";
            this.profileIcon.Size = new System.Drawing.Size(25, 25);
            this.profileIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileIcon.TabIndex = 5;
            this.profileIcon.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.backToSignIn);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.switchLabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.waringLabel);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.passIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.profileIcon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.PictureBox profileIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox passIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Label waringLabel;
        private System.Windows.Forms.Label switchLabel;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label backToSignIn;
        private System.Windows.Forms.PictureBox hidePassword;
        private System.Windows.Forms.PictureBox showPass;
    }
}

