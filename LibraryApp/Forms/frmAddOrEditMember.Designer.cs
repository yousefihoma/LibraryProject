using LibraryApp.Controls;

namespace LibraryApp.Forms
{
    partial class frmAddOrEditMember
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
            this.components = new System.ComponentModel.Container();
            this.lblMemberFirstName = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNationalityCode = new System.Windows.Forms.Label();
            this.lblBeginDate = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstDate = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblEducationLevelId = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnAddPictureMember = new System.Windows.Forms.Button();
            this.btnDeletePictureMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lblGenderId = new System.Windows.Forms.Label();
            this.cmbGenderId = new System.Windows.Forms.ComboBox();
            this.cmbEducationLevelId = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtBeginDate = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstDate = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pcMember = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberNum = new LibraryApp.Controls.CustomTextBox();
            this.txtNationalityCode = new LibraryApp.Controls.CustomTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMember)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberFirstName
            // 
            this.lblMemberFirstName.AutoSize = true;
            this.lblMemberFirstName.Location = new System.Drawing.Point(65, 54);
            this.lblMemberFirstName.Name = "lblMemberFirstName";
            this.lblMemberFirstName.Size = new System.Drawing.Size(20, 13);
            this.lblMemberFirstName.TabIndex = 1;
            this.lblMemberFirstName.Text = "نام";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(65, 124);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(35, 13);
            this.lblMobile.TabIndex = 1;
            this.lblMobile.Text = "موبایل";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(65, 194);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "ایمیل";
            // 
            // lblNationalityCode
            // 
            this.lblNationalityCode.AutoSize = true;
            this.lblNationalityCode.Location = new System.Drawing.Point(65, 264);
            this.lblNationalityCode.Name = "lblNationalityCode";
            this.lblNationalityCode.Size = new System.Drawing.Size(42, 13);
            this.lblNationalityCode.TabIndex = 1;
            this.lblNationalityCode.Text = "کد ملی";
            // 
            // lblBeginDate
            // 
            this.lblBeginDate.AutoSize = true;
            this.lblBeginDate.Location = new System.Drawing.Point(312, 119);
            this.lblBeginDate.Name = "lblBeginDate";
            this.lblBeginDate.Size = new System.Drawing.Size(65, 13);
            this.lblBeginDate.TabIndex = 1;
            this.lblBeginDate.Text = "تاریخ عضویت";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(312, 47);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(65, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "نام خانوادگی";
            // 
            // lblFirstDate
            // 
            this.lblFirstDate.AutoSize = true;
            this.lblFirstDate.Location = new System.Drawing.Point(312, 191);
            this.lblFirstDate.Name = "lblFirstDate";
            this.lblFirstDate.Size = new System.Drawing.Size(91, 13);
            this.lblFirstDate.TabIndex = 1;
            this.lblFirstDate.Text = "اولین تاریخ عضویت";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(312, 263);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(48, 13);
            this.lblBirthday.TabIndex = 1;
            this.lblBirthday.Text = "تاریخ تولد";
            // 
            // lblEducationLevelId
            // 
            this.lblEducationLevelId.AutoSize = true;
            this.lblEducationLevelId.Location = new System.Drawing.Point(312, 335);
            this.lblEducationLevelId.Name = "lblEducationLevelId";
            this.lblEducationLevelId.Size = new System.Drawing.Size(47, 13);
            this.lblEducationLevelId.TabIndex = 1;
            this.lblEducationLevelId.Text = "تحصیلات";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(552, 47);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(32, 13);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "آدرس";
            // 
            // btnAddPictureMember
            // 
            this.btnAddPictureMember.BackColor = System.Drawing.Color.Violet;
            this.btnAddPictureMember.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddPictureMember.ForeColor = System.Drawing.Color.Navy;
            this.btnAddPictureMember.Location = new System.Drawing.Point(590, 400);
            this.btnAddPictureMember.Name = "btnAddPictureMember";
            this.btnAddPictureMember.Size = new System.Drawing.Size(107, 23);
            this.btnAddPictureMember.TabIndex = 14;
            this.btnAddPictureMember.Text = "انتخاب عکس";
            this.btnAddPictureMember.UseVisualStyleBackColor = false;
            this.btnAddPictureMember.Click += new System.EventHandler(this.btnAddPictureMember_Click);
            // 
            // btnDeletePictureMember
            // 
            this.btnDeletePictureMember.BackColor = System.Drawing.Color.Violet;
            this.btnDeletePictureMember.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeletePictureMember.ForeColor = System.Drawing.Color.Navy;
            this.btnDeletePictureMember.Location = new System.Drawing.Point(723, 400);
            this.btnDeletePictureMember.Name = "btnDeletePictureMember";
            this.btnDeletePictureMember.Size = new System.Drawing.Size(112, 23);
            this.btnDeletePictureMember.TabIndex = 15;
            this.btnDeletePictureMember.Text = "حذف عکس";
            this.btnDeletePictureMember.UseVisualStyleBackColor = false;
            this.btnDeletePictureMember.Click += new System.EventHandler(this.btnDeletePictureMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.Violet;
            this.btnAddMember.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddMember.ForeColor = System.Drawing.Color.Navy;
            this.btnAddMember.Location = new System.Drawing.Point(433, 400);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(75, 23);
            this.btnAddMember.TabIndex = 12;
            this.btnAddMember.Text = "ثبت";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // lblGenderId
            // 
            this.lblGenderId.AutoSize = true;
            this.lblGenderId.Location = new System.Drawing.Point(65, 334);
            this.lblGenderId.Name = "lblGenderId";
            this.lblGenderId.Size = new System.Drawing.Size(44, 13);
            this.lblGenderId.TabIndex = 1;
            this.lblGenderId.Text = "جنسیت";
            // 
            // cmbGenderId
            // 
            this.cmbGenderId.FormattingEnabled = true;
            this.cmbGenderId.Items.AddRange(new object[] {
            "خانم",
            "آقا"});
            this.cmbGenderId.Location = new System.Drawing.Point(153, 331);
            this.cmbGenderId.Name = "cmbGenderId";
            this.cmbGenderId.Size = new System.Drawing.Size(121, 20);
            this.cmbGenderId.TabIndex = 9;
            // 
            // cmbEducationLevelId
            // 
            this.cmbEducationLevelId.FormattingEnabled = true;
            this.cmbEducationLevelId.Items.AddRange(new object[] {
            "زیر دیپلم",
            "دیپلم",
            "فوق دیپلم",
            "لیسانس",
            "فوق لیسانس",
            "دکتری"});
            this.cmbEducationLevelId.Location = new System.Drawing.Point(414, 335);
            this.cmbEducationLevelId.Name = "cmbEducationLevelId";
            this.cmbEducationLevelId.Size = new System.Drawing.Size(121, 20);
            this.cmbEducationLevelId.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(153, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(153, 118);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(121, 20);
            this.txtMobile.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(153, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtBeginDate
            // 
            this.txtBeginDate.Location = new System.Drawing.Point(414, 119);
            this.txtBeginDate.Name = "txtBeginDate";
            this.txtBeginDate.Size = new System.Drawing.Size(121, 20);
            this.txtBeginDate.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(414, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstDate
            // 
            this.txtFirstDate.Location = new System.Drawing.Point(414, 191);
            this.txtFirstDate.Name = "txtFirstDate";
            this.txtFirstDate.Size = new System.Drawing.Size(121, 20);
            this.txtFirstDate.TabIndex = 6;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(414, 263);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(121, 20);
            this.txtBirthday.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(590, 47);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 96);
            this.txtAddress.TabIndex = 11;
            this.txtAddress.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pcMember
            // 
            this.pcMember.Image = global::LibraryApp.Properties.Resources.no_profile_image;
            this.pcMember.Location = new System.Drawing.Point(595, 160);
            this.pcMember.Name = "pcMember";
            this.pcMember.Size = new System.Drawing.Size(240, 214);
            this.pcMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcMember.TabIndex = 2;
            this.pcMember.TabStop = false;
            this.pcMember.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcMember_DragDrop);
            this.pcMember.DragEnter += new System.Windows.Forms.DragEventHandler(this.pcMember_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "شماره عضویت";
            // 
            // txtMemberNum
            // 
            this.txtMemberNum.CustomValidationMessage = "";
            this.txtMemberNum.FieldPersianName = "شماره عضویت";
            this.txtMemberNum.IsMandatory = true;
            this.txtMemberNum.Location = new System.Drawing.Point(153, 402);
            this.txtMemberNum.Name = "txtMemberNum";
            this.txtMemberNum.Size = new System.Drawing.Size(121, 20);
            this.txtMemberNum.TabIndex = 16;
            this.txtMemberNum.TextBoxMode = LibraryApp.Controls.TextBoxMode.Number;
            this.txtMemberNum.MouseLeave += new System.EventHandler(this.txtMemberNum_MouseLeave);
            // 
            // txtNationalityCode
            // 
            this.txtNationalityCode.CustomValidationMessage = "طول کد ملی اشتباه است";
            this.txtNationalityCode.FieldPersianName = "کد ملی";
            this.txtNationalityCode.IsMandatory = true;
            this.txtNationalityCode.Location = new System.Drawing.Point(153, 260);
            this.txtNationalityCode.MaxLength = 10;
            this.txtNationalityCode.Name = "txtNationalityCode";
            this.txtNationalityCode.Size = new System.Drawing.Size(121, 20);
            this.txtNationalityCode.TabIndex = 7;
            this.txtNationalityCode.TextBoxMode = LibraryApp.Controls.TextBoxMode.NationalCode;
            // 
            // frmAddOrEditMember
            // 
            this.AcceptButton = this.btnAddMember;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(845, 451);
            this.Controls.Add(this.txtMemberNum);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtFirstDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtBeginDate);
            this.Controls.Add(this.txtNationalityCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.cmbEducationLevelId);
            this.Controls.Add(this.cmbGenderId);
            this.Controls.Add(this.btnDeletePictureMember);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnAddPictureMember);
            this.Controls.Add(this.pcMember);
            this.Controls.Add(this.lblEducationLevelId);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGenderId);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblNationalityCode);
            this.Controls.Add(this.lblFirstDate);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblBeginDate);
            this.Controls.Add(this.lblMemberFirstName);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAddOrEditMember";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن عضو";
            this.Load += new System.EventHandler(this.frmAddOrEditMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMemberFirstName;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNationalityCode;
        private System.Windows.Forms.PictureBox pcMember;
        private System.Windows.Forms.Label lblBeginDate;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstDate;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblEducationLevelId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnAddPictureMember;
        private System.Windows.Forms.Button btnDeletePictureMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblGenderId;
        private System.Windows.Forms.ComboBox cmbGenderId;
        private System.Windows.Forms.ComboBox cmbEducationLevelId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private CustomTextBox txtNationalityCode;
        private System.Windows.Forms.TextBox txtBeginDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstDate;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private CustomTextBox txtMemberNum;
        private System.Windows.Forms.Label label1;
    }
}