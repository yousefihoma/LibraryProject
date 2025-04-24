namespace LibraryApp.Forms
{
    partial class frmBook
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddBook = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteBook = new System.Windows.Forms.ToolStripButton();
            this.btnEditBook = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshBook = new System.Windows.Forms.ToolStripButton();
            this.lblSearchBook = new System.Windows.Forms.ToolStripLabel();
            this.txtFilterBook = new System.Windows.Forms.ToolStripTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddBook,
            this.btnDeleteBook,
            this.btnEditBook,
            this.btnRefreshBook,
            this.lblSearchBook,
            this.txtFilterBook});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(922, 64);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Image = global::LibraryApp.Properties.Resources._1371475930_filenew;
            this.btnAddBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAddBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(44, 61);
            this.btnAddBook.Text = "جدید";
            this.btnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Image = global::LibraryApp.Properties.Resources._1371476007_Close_Box_Red;
            this.btnDeleteBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnDeleteBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(44, 61);
            this.btnDeleteBook.Text = "حذف";
            this.btnDeleteBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.Image = global::LibraryApp.Properties.Resources._1371475973_document_edit;
            this.btnEditBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(50, 61);
            this.btnEditBook.Text = "ویرایش";
            this.btnEditBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnRefreshBook
            // 
            this.btnRefreshBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBook.Image = global::LibraryApp.Properties.Resources._1371476342_Refresh;
            this.btnRefreshBook.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRefreshBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshBook.Name = "btnRefreshBook";
            this.btnRefreshBook.Size = new System.Drawing.Size(64, 61);
            this.btnRefreshBook.Text = "بروزرسانی";
            this.btnRefreshBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefreshBook.Click += new System.EventHandler(this.btnRefreshBook_Click);
            // 
            // lblSearchBook
            // 
            this.lblSearchBook.Name = "lblSearchBook";
            this.lblSearchBook.Size = new System.Drawing.Size(41, 61);
            this.lblSearchBook.Text = "جستجو";
            // 
            // txtFilterBook
            // 
            this.txtFilterBook.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterBook.Name = "txtFilterBook";
            this.txtFilterBook.Size = new System.Drawing.Size(100, 64);
            this.txtFilterBook.TextChanged += new System.EventHandler(this.txtFilterBook_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvBook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 456);
            this.panel1.TabIndex = 1;
            // 
            // dgvBook
            // 
            this.dgvBook.AllowUserToAddRows = false;
            this.dgvBook.AllowUserToDeleteRows = false;
            this.dgvBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.BookTitle,
            this.Author,
            this.ISBN,
            this.Price});
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Location = new System.Drawing.Point(0, 0);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.ReadOnly = true;
            this.dgvBook.Size = new System.Drawing.Size(922, 456);
            this.dgvBook.TabIndex = 0;
            // 
            // BookID
            // 
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            this.BookID.Visible = false;
            // 
            // BookTitle
            // 
            this.BookTitle.DataPropertyName = "Title";
            this.BookTitle.HeaderText = "عنوان کتاب";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "نویسنده";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(922, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 520);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "کتاب";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnAddBook;
        private System.Windows.Forms.ToolStripButton btnDeleteBook;
        private System.Windows.Forms.ToolStripButton btnEditBook;
        private System.Windows.Forms.ToolStripButton btnRefreshBook;
        private System.Windows.Forms.ToolStripLabel lblSearchBook;
        private System.Windows.Forms.ToolStripTextBox txtFilterBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}