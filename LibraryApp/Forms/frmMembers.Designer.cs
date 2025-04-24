namespace LibraryApp.Forms
{
    partial class frmMembers
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddMember = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteMember = new System.Windows.Forms.ToolStripButton();
            this.btnEditMember = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lblSearch = new System.Windows.Forms.ToolStripLabel();
            this.txtFilterMember = new System.Windows.Forms.ToolStripTextBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MeliCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MembershipDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EducationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(16, 0, 1, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1269, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddMember,
            this.btnDeleteMember,
            this.btnEditMember,
            this.btnRefresh,
            this.lblSearch,
            this.txtFilterMember});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1269, 66);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Image = global::LibraryApp.Properties.Resources._1371475930_filenew;
            this.btnAddMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(44, 63);
            this.btnAddMember.Text = "جدید";
            this.btnAddMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.Image = global::LibraryApp.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeleteMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(44, 63);
            this.btnDeleteMember.Text = "حذف";
            this.btnDeleteMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteMember.ToolTipText = "حذف";
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.Image = global::LibraryApp.Properties.Resources._1371475973_document_edit;
            this.btnEditMember.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(56, 63);
            this.btnEditMember.Text = "ویرایش";
            this.btnEditMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditMember.ToolTipText = "ویرایش";
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = global::LibraryApp.Properties.Resources._1371476342_Refresh;
            this.btnRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(73, 63);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 63);
            this.lblSearch.Text = "جستجو:";
            // 
            // txtFilterMember
            // 
            this.txtFilterMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterMember.Name = "txtFilterMember";
            this.txtFilterMember.Size = new System.Drawing.Size(116, 66);
            this.txtFilterMember.TextChanged += new System.EventHandler(this.txtFilterMember_TextChanged);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberId,
            this.Name,
            this.MemberName,
            this.Mobile,
            this.MeliCode,
            this.MembershipDate,
            this.MemberNum,
            this.Gender,
            this.EducationId,
            this.BeginDate,
            this.NationalCode,
            this.BirthDate,
            this.Address});
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(0, 66);
            this.dgvMembers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(1269, 512);
            this.dgvMembers.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::LibraryApp.Properties.Resources.Untitled_1;
            this.btnBack.Location = new System.Drawing.Point(0, 571);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 31);
            this.btnBack.TabIndex = 4;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // MemberId
            // 
            this.MemberId.DataPropertyName = "MemberId";
            this.MemberId.HeaderText = "MemberId";
            this.MemberId.MinimumWidth = 6;
            this.MemberId.Name = "MemberId";
            this.MemberId.ReadOnly = true;
            this.MemberId.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "FirstName";
            this.Name.HeaderText = "نام";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // MemberName
            // 
            this.MemberName.DataPropertyName = "LastName";
            this.MemberName.HeaderText = "نام خانوادگی";
            this.MemberName.MinimumWidth = 6;
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Phone";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.MinimumWidth = 6;
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            // 
            // MeliCode
            // 
            this.MeliCode.DataPropertyName = "Email";
            this.MeliCode.HeaderText = "ایمیل";
            this.MeliCode.MinimumWidth = 6;
            this.MeliCode.Name = "MeliCode";
            this.MeliCode.ReadOnly = true;
            // 
            // MembershipDate
            // 
            this.MembershipDate.DataPropertyName = "MembershipDate";
            this.MembershipDate.HeaderText = "تاریخ عضویت";
            this.MembershipDate.MinimumWidth = 6;
            this.MembershipDate.Name = "MembershipDate";
            this.MembershipDate.ReadOnly = true;
            // 
            // MemberNum
            // 
            this.MemberNum.DataPropertyName = "MemberNum";
            this.MemberNum.HeaderText = "شماره عضویت";
            this.MemberNum.Name = "MemberNum";
            this.MemberNum.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "GenderID";
            this.Gender.HeaderText = "جنسیت";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // EducationId
            // 
            this.EducationId.DataPropertyName = "EducationId";
            this.EducationId.HeaderText = "تحصیلات";
            this.EducationId.Name = "EducationId";
            this.EducationId.ReadOnly = true;
            // 
            // BeginDate
            // 
            this.BeginDate.DataPropertyName = "BeginDate";
            this.BeginDate.HeaderText = "BeginDate";
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.ReadOnly = true;
            // 
            // NationalCode
            // 
            this.NationalCode.DataPropertyName = "NationalCode";
            this.NationalCode.HeaderText = "NationalCode";
            this.NationalCode.Name = "NationalCode";
            this.NationalCode.ReadOnly = true;
            // 
            // BirthDate
            // 
            this.BirthDate.DataPropertyName = "BirthDate";
            this.BirthDate.HeaderText = "BirthDate";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1269, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "frmMembers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اعضاء";
            this.Load += new System.EventHandler(this.frmMembers_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.ToolStripButton btnAddMember;
        private System.Windows.Forms.ToolStripButton btnDeleteMember;
        private System.Windows.Forms.ToolStripButton btnEditMember;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripLabel lblSearch;
        private System.Windows.Forms.ToolStripTextBox txtFilterMember;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn MeliCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembershipDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EducationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}