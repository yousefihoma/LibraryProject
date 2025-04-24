namespace LibraryApp.Forms
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pcLock = new System.Windows.Forms.PictureBox();
            this.lblChangePassword = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUserAndIP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcLock)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(100, 153);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(178, 22);
            this.txtPassword.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 105);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(178, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName.Location = new System.Drawing.Point(299, 113);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(70, 14);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "نام کاربری:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassword.Location = new System.Drawing.Point(308, 156);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 14);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "رمز عبور:";
            // 
            // pcLock
            // 
            this.pcLock.BackColor = System.Drawing.Color.Transparent;
            this.pcLock.BackgroundImage = global::LibraryApp.Properties.Resources.Login;
            this.pcLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcLock.Location = new System.Drawing.Point(-4, 11);
            this.pcLock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pcLock.Name = "pcLock";
            this.pcLock.Size = new System.Drawing.Size(96, 74);
            this.pcLock.TabIndex = 3;
            this.pcLock.TabStop = false;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.lblChangePassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblChangePassword.Location = new System.Drawing.Point(240, 11);
            this.lblChangePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(196, 14);
            this.lblChangePassword.TabIndex = 2;
            this.lblChangePassword.Text = "رمز عبور خود را فراموش کرده ام";
            this.lblChangePassword.Click += new System.EventHandler(this.lblChangePassword_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnLogin.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLogin.Location = new System.Drawing.Point(237, 201);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "ورود";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(88, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "خروج";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(90)))));
            this.label3.Location = new System.Drawing.Point(212, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "سیستم مدیریت کتابخانه های عمومی";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.BackgroundImage = global::LibraryApp.Properties.Resources.pngimg1;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.pcLock);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Location = new System.Drawing.Point(0, -12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 295);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radioButton1.Location = new System.Drawing.Point(253, 202);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radioButton1.Size = new System.Drawing.Size(59, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ادمین";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.lblChangePassword);
            this.panel3.Controls.Add(this.lblUserAndIP);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 235);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(445, 34);
            this.panel3.TabIndex = 10;
            // 
            // lblUserAndIP
            // 
            this.lblUserAndIP.AutoSize = true;
            this.lblUserAndIP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserAndIP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblUserAndIP.Location = new System.Drawing.Point(27, 11);
            this.lblUserAndIP.Name = "lblUserAndIP";
            this.lblUserAndIP.Size = new System.Drawing.Size(54, 14);
            this.lblUserAndIP.TabIndex = 7;
            this.lblUserAndIP.Text = "PcName";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 269);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcLock)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.PictureBox pcLock;
        private System.Windows.Forms.Label lblChangePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label lblUserAndIP;
    }
}