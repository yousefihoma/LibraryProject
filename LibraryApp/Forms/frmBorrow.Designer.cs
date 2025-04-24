namespace LibraryApp.Forms
{
    partial class frmBorrow
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
            this.btnBackToHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectBooks = new System.Windows.Forms.Button();
            this.cmBookName = new System.Windows.Forms.ComboBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.btnRegisterBorrow = new System.Windows.Forms.Button();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.cmbMemberName = new System.Windows.Forms.ComboBox();
            this.cmbPersonelName = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblIsRevival = new System.Windows.Forms.Label();
            this.txtNationalCode = new System.Windows.Forms.TextBox();
            this.cmbIisRivival = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnBackToHome
            // 
            this.btnBackToHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBackToHome.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnBackToHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBackToHome.Location = new System.Drawing.Point(337, 421);
            this.btnBackToHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackToHome.Name = "btnBackToHome";
            this.btnBackToHome.Size = new System.Drawing.Size(99, 40);
            this.btnBackToHome.TabIndex = 0;
            this.btnBackToHome.Text = "بازگشت";
            this.btnBackToHome.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام عضو";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "کد ملی";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 208);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "تاریخ تحویل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "نام متصدی";
            // 
            // btnSelectBooks
            // 
            this.btnSelectBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSelectBooks.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSelectBooks.Location = new System.Drawing.Point(474, 31);
            this.btnSelectBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectBooks.Name = "btnSelectBooks";
            this.btnSelectBooks.Size = new System.Drawing.Size(119, 40);
            this.btnSelectBooks.TabIndex = 0;
            this.btnSelectBooks.Text = "انتخاب کتابها";
            this.btnSelectBooks.UseVisualStyleBackColor = false;
            this.btnSelectBooks.Click += new System.EventHandler(this.btnSelectBooks_Click);
            // 
            // cmBookName
            // 
            this.cmBookName.FormattingEnabled = true;
            this.cmBookName.Location = new System.Drawing.Point(618, 40);
            this.cmBookName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmBookName.Name = "cmBookName";
            this.cmBookName.Size = new System.Drawing.Size(277, 24);
            this.cmBookName.TabIndex = 2;
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 16;
            this.lstBooks.Location = new System.Drawing.Point(618, 107);
            this.lstBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(277, 228);
            this.lstBooks.TabIndex = 3;
            // 
            // btnRegisterBorrow
            // 
            this.btnRegisterBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegisterBorrow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnRegisterBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegisterBorrow.Location = new System.Drawing.Point(114, 421);
            this.btnRegisterBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegisterBorrow.Name = "btnRegisterBorrow";
            this.btnRegisterBorrow.Size = new System.Drawing.Size(102, 40);
            this.btnRegisterBorrow.TabIndex = 0;
            this.btnRegisterBorrow.Text = "ثبت";
            this.btnRegisterBorrow.UseVisualStyleBackColor = false;
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.Location = new System.Drawing.Point(755, 420);
            this.lblTodayDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(62, 16);
            this.lblTodayDate.TabIndex = 1;
            this.lblTodayDate.Text = "تاریخ امروز";
            // 
            // cmbMemberName
            // 
            this.cmbMemberName.FormattingEnabled = true;
            this.cmbMemberName.Location = new System.Drawing.Point(183, 40);
            this.cmbMemberName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMemberName.Name = "cmbMemberName";
            this.cmbMemberName.Size = new System.Drawing.Size(252, 24);
            this.cmbMemberName.TabIndex = 2;
            // 
            // cmbPersonelName
            // 
            this.cmbPersonelName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbPersonelName.FormattingEnabled = true;
            this.cmbPersonelName.Location = new System.Drawing.Point(183, 347);
            this.cmbPersonelName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPersonelName.Name = "cmbPersonelName";
            this.cmbPersonelName.Size = new System.Drawing.Size(252, 24);
            this.cmbPersonelName.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 204);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(252, 23);
            this.textBox3.TabIndex = 9;
            // 
            // lblIsRevival
            // 
            this.lblIsRevival.AutoSize = true;
            this.lblIsRevival.Location = new System.Drawing.Point(59, 280);
            this.lblIsRevival.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIsRevival.Name = "lblIsRevival";
            this.lblIsRevival.Size = new System.Drawing.Size(37, 16);
            this.lblIsRevival.TabIndex = 1;
            this.lblIsRevival.Text = "تمدید";
            // 
            // txtNationalCode
            // 
            this.txtNationalCode.Location = new System.Drawing.Point(183, 123);
            this.txtNationalCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNationalCode.Name = "txtNationalCode";
            this.txtNationalCode.Size = new System.Drawing.Size(252, 23);
            this.txtNationalCode.TabIndex = 6;
            // 
            // cmbIisRivival
            // 
            this.cmbIisRivival.FormattingEnabled = true;
            this.cmbIisRivival.Location = new System.Drawing.Point(183, 276);
            this.cmbIisRivival.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbIisRivival.Name = "cmbIisRivival";
            this.cmbIisRivival.Size = new System.Drawing.Size(252, 24);
            this.cmbIisRivival.TabIndex = 8;
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(905, 483);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cmbIisRivival);
            this.Controls.Add(this.cmbPersonelName);
            this.Controls.Add(this.txtNationalCode);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.cmbMemberName);
            this.Controls.Add(this.cmBookName);
            this.Controls.Add(this.lblIsRevival);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTodayDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectBooks);
            this.Controls.Add(this.btnRegisterBorrow);
            this.Controls.Add(this.btnBackToHome);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBorrow";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frmBorrow";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackToHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSelectBooks;
        private System.Windows.Forms.ComboBox cmBookName;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.Button btnRegisterBorrow;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.ComboBox cmbMemberName;
        private System.Windows.Forms.ComboBox cmbPersonelName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblIsRevival;
        private System.Windows.Forms.TextBox txtNationalCode;
        private System.Windows.Forms.ComboBox cmbIisRivival;
    }
}