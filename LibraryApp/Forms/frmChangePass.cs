using Library1Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library1Data.Context;
using Library1Data;
using Telerik.WinControls.Extensions;
using Library1Data.Context;
namespace LibraryApp.Forms
{
    public partial class frmChangePass : Form
    {
        public string UserName;
        public frmChangePass()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(btnChangePass_KeyDown);
        }
        private void frmChangePass_Load(object sender, EventArgs e)
        {
            txtUserName.Text = UserName;
            Design.AnimateWindow(this.Handle, 1000, Design.HOR_NEGATIVE);
        }
        private void btnChangePass_Click(object sender, EventArgs e)
        {
            bool v = false;
            try
            {
                Tools.CheckPasswordStrength(txtNewPassword.Text);
                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    RtlMessageBox.Show("رمز با تکرار رمز برابر نیست", "توجه");
                }
                else
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {

                        //Hass pass     
                        {//>??????
                            var login = db.LoginRepository.GetAllAsQueryable().First(r=>r.UserName.Trim().ToLower() == txtUserName.Text.Trim().ToLower());
                           // login.UserName = txtUserName.Text;
                            login.Password = txtNewPassword.Text;
                           // db.LoginRepository.Update(login);
                            db.Save();
                            RtlMessageBox.Show("رمز با موفقیت تغییر کرد");

                        }
                    }
                    //this.Dispose();
                    //frmLogin frmLogin = new frmLogin();
                    //if (frmLogin == null)
                    //{
                    //    frmLogin.ShowDialog();
                    //}
                    //else
                    //{
                    //    frmLogin.BringToFront();
                    //}
                    //frmLogin.ShowDialog();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده است", "خطا");

            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frmLogin frmLogin = new frmLogin();
            if (frmLogin == null)
            {
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.BringToFront();
            }
            frmLogin.ShowDialog();
        }
        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPassword.Checked)
            {
                txtNewPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtNewPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
        }

        private void btnChangePass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChangePass.PerformClick();
                e.Handled = true; // جلوگیری از پردازش بیشتر
            }
        }
    }
}
