namespace LibraryApp.Forms
{
    partial class frmAddEditBook
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
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddOrEditBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Location = new System.Drawing.Point(138, 58);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(142, 23);
            this.txtBookTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(138, 112);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(142, 23);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(138, 166);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(142, 23);
            this.txtISBN.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(438, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(142, 23);
            this.textBox4.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(438, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "عنوان:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "نویسنده";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "مترجم";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(376, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "دسته";
            // 
            // btnAddOrEditBook
            // 
            this.btnAddOrEditBook.Location = new System.Drawing.Point(151, 310);
            this.btnAddOrEditBook.Name = "btnAddOrEditBook";
            this.btnAddOrEditBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrEditBook.TabIndex = 10;
            this.btnAddOrEditBook.Text = "افزودن";
            this.btnAddOrEditBook.UseVisualStyleBackColor = true;
            this.btnAddOrEditBook.Click += new System.EventHandler(this.btnAddOrEditBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(438, 310);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 222);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "چاپ:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(438, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 23);
            this.textBox2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(372, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "قیمت:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(438, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(142, 23);
            this.textBox3.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "ناشر:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(138, 275);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(142, 23);
            this.textBox5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "تعداد:";
            // 
            // frmAddEditBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(603, 355);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddOrEditBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookTitle);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddEditBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "افزودن کتاب";
            this.Load += new System.EventHandler(this.frmAddEditBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddOrEditBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
    }
}