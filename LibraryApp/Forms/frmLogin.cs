using Library1Data.Context;
using Library1Utility;
using Microsoft.Win32;
using System;
using System.Linq;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class frmLogin : Form
    {
                public frmLogin()
        {

            InitializeComponent();
        }
        #region Move
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int  HT_CAPTION= 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion
        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = Environment.UserName;
            string IP = Tools.GetLocalIP();
            lblUserAndIP.Text = $"PC Name: {UserName}  IP: {IP}  ";
            RegistryKey masterKey = Registry.CurrentUser.CreateSubKey("software\\Library");
            txtUserName.Text = (string)masterKey.GetValue("UserNameRegister");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtUserName.Text)) && (string.IsNullOrEmpty(txtPassword.Text)))
            {
                RtlMessageBox.Show("لطفا نام کاربری و رمز عبور را وارد کنید");
            }
            using (UnitOfWork db = new UnitOfWork())
            {
                if (db.LoginRepository.GetAll(u => u.UserName == txtUserName.Text && u.Password == txtPassword.Text).Any())

                {
                    RegistryKey UsernameKey = Registry.CurrentUser.CreateSubKey("SoftWare\\Library");
                    try
                    {
                        UsernameKey.SetValue("UserNameRegister", txtUserName.Text.Trim());
                        Close();
                        frmMain frmMain = new frmMain();
                        frmMain.UserName = txtUserName.Text;
                        frmMain.ShowDialog();

                    }
                    catch
                    {
                        RtlMessageBox.Show("خطا در ورود به برنامه");
                    }
                    finally
                    {
                        UsernameKey.Close();
                    }
                }
                else
                {
                    RtlMessageBox.Show("کاربری یافت نشد", "خطا");
                }
            }
        }
    
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            txtUserName.Text = (txtUserName.Text).ToLower();
        }
        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(txtUserName.Text)) || (string.IsNullOrWhiteSpace(txtUserName.Text)))
            {
                RtlMessageBox.Show("لطفا نام کاربری را وارد کنید", "توجه");
            }
            else
            {//???????????????/ خطای تغییر رمز
                frmChangePass frmChangePass = new frmChangePass();
                frmChangePass.UserName = txtUserName.Text;
                frmChangePass.ShowDialog();
                 
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(((Control)sender).Name);
           

            if(e.Button == MouseButtons.Left){
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}






