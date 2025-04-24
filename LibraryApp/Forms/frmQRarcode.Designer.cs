namespace LibraryApp.Forms
{
    partial class frmQRCode
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
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.btnShowQRCode = new System.Windows.Forms.Button();
            this.pcViewQrCode = new System.Windows.Forms.PictureBox();
            this.btnSaveQRCode = new System.Windows.Forms.Button();
            this.txtSaveQRCode = new System.Windows.Forms.TextBox();
            this.pcSaveQRCode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcViewQrCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSaveQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBookCode
            // 
            this.txtBookCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookCode.Location = new System.Drawing.Point(610, 86);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(162, 27);
            this.txtBookCode.TabIndex = 0;
            this.txtBookCode.TextChanged += new System.EventHandler(this.txtBookCode_TextChanged);
            // 
            // btnShowQRCode
            // 
            this.btnShowQRCode.Location = new System.Drawing.Point(529, 84);
            this.btnShowQRCode.Name = "btnShowQRCode";
            this.btnShowQRCode.Size = new System.Drawing.Size(75, 27);
            this.btnShowQRCode.TabIndex = 1;
            this.btnShowQRCode.Text = "نمایش";
            this.btnShowQRCode.UseVisualStyleBackColor = true;
            this.btnShowQRCode.Click += new System.EventHandler(this.btnShowQRCode_Click);
            // 
            // pcViewQrCode
            // 
            this.pcViewQrCode.Location = new System.Drawing.Point(466, 119);
            this.pcViewQrCode.Name = "pcViewQrCode";
            this.pcViewQrCode.Size = new System.Drawing.Size(306, 184);
            this.pcViewQrCode.TabIndex = 2;
            this.pcViewQrCode.TabStop = false;
            this.pcViewQrCode.Click += new System.EventHandler(this.pcViewQrCode_Click);
            // 
            // btnSaveQRCode
            // 
            this.btnSaveQRCode.Location = new System.Drawing.Point(168, 86);
            this.btnSaveQRCode.Name = "btnSaveQRCode";
            this.btnSaveQRCode.Size = new System.Drawing.Size(66, 27);
            this.btnSaveQRCode.TabIndex = 1;
            this.btnSaveQRCode.Text = "ذخیره";
            this.btnSaveQRCode.UseVisualStyleBackColor = true;
            this.btnSaveQRCode.Click += new System.EventHandler(this.btnSaveQRCode_Click);
            // 
            // txtSaveQRCode
            // 
            this.txtSaveQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSaveQRCode.Location = new System.Drawing.Point(236, 86);
            this.txtSaveQRCode.Name = "txtSaveQRCode";
            this.txtSaveQRCode.Size = new System.Drawing.Size(178, 27);
            this.txtSaveQRCode.TabIndex = 0;
            this.txtSaveQRCode.TextChanged += new System.EventHandler(this.txtBookCode_TextChanged);
            // 
            // pcSaveQRCode
            // 
            this.pcSaveQRCode.Location = new System.Drawing.Point(108, 119);
            this.pcSaveQRCode.Name = "pcSaveQRCode";
            this.pcSaveQRCode.Size = new System.Drawing.Size(306, 184);
            this.pcSaveQRCode.TabIndex = 2;
            this.pcSaveQRCode.TabStop = false;
            this.pcSaveQRCode.Click += new System.EventHandler(this.pcViewQrCode_Click);
            // 
            // frmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 534);
            this.Controls.Add(this.pcSaveQRCode);
            this.Controls.Add(this.pcViewQrCode);
            this.Controls.Add(this.btnSaveQRCode);
            this.Controls.Add(this.btnShowQRCode);
            this.Controls.Add(this.txtSaveQRCode);
            this.Controls.Add(this.txtBookCode);
            this.Font = new System.Drawing.Font("Tahoma", 9.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmQRCode";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcViewQrCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcSaveQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Button btnShowQRCode;
        private System.Windows.Forms.PictureBox pcViewQrCode;
        private System.Windows.Forms.Button btnSaveQRCode;
        private System.Windows.Forms.TextBox txtSaveQRCode;
        private System.Windows.Forms.PictureBox pcSaveQRCode;
    }
}