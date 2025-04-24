using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace LibraryApp.Forms
{
    public partial class frmQRCode : Form
    {
        public frmQRCode()
        {
            InitializeComponent();
        }

        private void btnShowQRCode_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/QRCode/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            try
            {
                if (txtBookCode.Text != "")
                {

                    pcViewQrCode.Image = new Bitmap(path + txtBookCode.Text + ".jpg");
                }
                else
                {
                    MessageBox.Show("لطفا یک کد وارد کنید");
                }
            }
            catch
            {

                MessageBox.Show("لطفا یک کد معتبر وارد کنید");
            }

        }

        private void txtBookCode_TextChanged(object sender, EventArgs e)
        {
            QRCodeEncoder QRC = new QRCodeEncoder();
            QRC.QRCodeScale = 6;
            QRC.QRCodeVersion = 6;
            pcSaveQRCode.Image = QRC.Encode(txtSaveQRCode.Text);

        }

        private void btnSaveQRCode_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "/QRCode/";
            try
            {
                if (txtSaveQRCode.Text != "")
                {

                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    pcSaveQRCode.Image.Save(path + txtSaveQRCode.Text + ".jpg");

                    MessageBox.Show("ذخیره شد QRCode");
                }
                else
                {
                    MessageBox.Show("لطفا یک کد وارد کنید");

                }
            }
            catch
            {

                MessageBox.Show("لطفا یک کد غیر تکراری وارد کنید");
            }
        }

        private void pcViewQrCode_Click(object sender, EventArgs e)
        {

        }

        private void frmQRCode_Load(object sender, EventArgs e)
        {

        }
    }
}
