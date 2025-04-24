using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library1Utility;
using Library1Data.Context;
using System.IO;
using Library1Data;
using Telerik.WinControls.Primitives;
using LibraryData;
using LibraryApp.Controls;


namespace LibraryApp.Forms
{
    public partial class frmAddOrEditMember : Form
    {
        public int MemberId = 0;
        UnitOfWork db;
        public frmAddOrEditMember()
        {
            InitializeComponent();
        }
        private void frmAddOrEditMember_Load(object sender, EventArgs e)
        {
            pcMember.AllowDrop = true;
            db = new UnitOfWork();
            if (MemberId != 0)
            {
                this.Text = "ویرایش شخص";
                btnAddMember.Text = "ویرایش";
                var member = db.MemberRepository.GetById(MemberId);
                txtFirstName.Text = member.FirstName;
                txtLastName.Text = member.LastName;
                txtEmail.Text = member.Email;
                txtMobile.Text = member.Phone;
                txtBeginDate.Text = member.MembershipDate;
                txtMemberNum.Text = (member.MemberNum).ToString();
                txtBeginDate.Text = member.BeginDate;
                txtNationalityCode.Text = member.NationalCode;
                txtBirthday.Text = member.BirthDate;
                cmbGenderId.SelectedItem = member.GenderID;
                cmbEducationLevelId.SelectedItem = member.EducationId;
                txtAddress.Text = member.Address;
                pcMember.ImageLocation = Application.StartupPath + "/MemberImage/" + member.PhotoMember;
            }
            db.Dispose();
        }




        private void btnAddPictureMember_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcMember.ImageLocation = openFile.FileName;
            }
        }
        private void btnAddMember_Click(object sender, EventArgs e)
        {
            #region Validation
            //foreach(CustomTextBox c in Controls.OfType<Control>().Where(r=>r.GetType() == typeof(CustomTextBox)))
            //{
            //    if (!c.IsValid)
            //    {
            //        MessageBox.Show("Test");
            //    }
            //}
            var invalidControls = Controls.OfType<Control>().Where(r => r.GetType() == typeof(CustomTextBox) && ((CustomTextBox)r).IsValid == false);
            if(invalidControls.Any())
            {
                var fields = invalidControls.Select(r => ((CustomTextBox)r).CustomValidationMessage ).Aggregate((a, b) => a + Environment.NewLine + b);
                var invalidInputMsg = $"خطاهای زیر در اطلاعات ورودی رخ داده است:{Environment.NewLine}{fields}";
                // MessageBox.Show(invalidInputMsg);
                throw new ApplicationException(invalidInputMsg);
            }

            #endregion
            // Async ?     
            string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcMember.ImageLocation);
            string path = Application.StartupPath + "/MemberImage/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            pcMember.Image.Save(path + imageName);

           // Tools.NationalCodeChek(txtNationalityCode.Text);
           if(!txtNationalityCode.Text.IsNationalCodeValid(out var message))
            {
                //throw new Exception(message);
                MessageBox.Show(message);
                return;
            }
            int GenderId = (cmbGenderId.SelectedItem == "خانم") ? 0 : 1;
            int Education = 1;
            switch (cmbEducationLevelId.SelectedItem)
            {
                case "زیر دیپلم":
                    Education = 1;
                    break;
                case "دیپلم":
                    Education = 2;
                    break;
                case "فوق دیپلم":
                    Education = 3;
                    break;
                case "لیسانس":
                    Education = 4;
                    break;
                case "فوق لیسانس":
                    Education = 5;
                    break;
                case "دکتری":
                    Education = 6;
                    break;
            }

            try
            {
                Members memberRow = new Members();
                if (MemberId != 0)
                {
                    memberRow = db.MemberRepository.GetById(MemberId);
                }
                else
                {
                    db.MemberRepository.Insert(memberRow);
                }

                memberRow.FirstName = txtFirstName.Text;
                memberRow.LastName = txtLastName.Text;
                memberRow.Phone = txtMobile.Text;
                memberRow.Email = txtEmail.Text;
                memberRow.MembershipDate = txtBeginDate.Text;
                memberRow.MemberNum = int.Parse(txtMemberNum.Text);
                memberRow.BeginDate = txtBeginDate.Text;
                memberRow.NationalCode = txtNationalityCode.Text;
                memberRow.BirthDate = txtBirthday.Text;
                memberRow.GenderID = GenderId;
                memberRow.EducationId = Education;
                memberRow.Address = txtAddress.Text;
                memberRow.PhotoMember = imageName;

                db.Save();
                DialogResult = DialogResult.OK;
                //Close();
                db.Dispose();



                #region Old
                //db = new UnitOfWork();
                //Members member1 = new Members
                //{
                //    FirstName = txtFirstName.Text,
                //    LastName = txtLastName.Text,
                //    Phone = txtMobile.Text,
                //    Email = txtEmail.Text,
                //    MembershipDate = txtBeginDate.Text,
                //    MemberNum = int.Parse(txtMemberNum.Text),
                //    BeginDate = txtBeginDate.Text,
                //    NationalCode = txtNationalityCode.Text,
                //    BirthDate = txtBirthday.Text,
                //    GenderID = GenderId,
                //    EducationId = Education,
                //    Address = txtAddress.Text,
                //    PhotoMember = imageName
                //};


                //if (MemberId != 0)
                //{
                //    var member = db.MemberRepository.GetById(MemberId);
                //    member1.MemberID = MemberId;
                //    db.MemberRepository.Update(member1);
                //}
                //if (MemberId == 0)
                //{


                //    db.MemberRepository.Insert(member1);
                //}
                //db.Save();
                //DialogResult = DialogResult.OK;
                //db.Dispose(); 
                #endregion
            }
            catch
            {
                if ((string.IsNullOrWhiteSpace(txtMemberNum.Text)))
                {
                    RtlMessageBox.Show("وارد کردن شماره عضویت الزامی است");

                    //throw new Exception("وارد کردن شماره عضویت الزامی است");
                }
            }
        }
        private void btnDeletePictureMember_Click(object sender, EventArgs e)
        {
            this.pcMember.Image = null;
        }
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            Mandatory(txtFirstName.Text, txtFirstName, "نام");
        }

        private void pcMember_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void pcMember_DragDrop(object sender, DragEventArgs e)
        {
            foreach (string pic in ((string[])e.Data.GetData(DataFormats.FileDrop)))
            {
                Image image = Image.FromFile(pic);
                pcMember.Image = image;
            }
        }

        private void txtMemberNum_MouseLeave(object sender, EventArgs e)
        {
            Mandatory(txtFirstName.Text, txtFirstName, "شماره عضویت");


        }
        public void Mandatory(string s, Control e, string ss)
        {
            if (string.IsNullOrEmpty(s))
            {
                errorProvider1.SetError(e, $"وارد کردن {ss} الزامی است");
            }
            else
            {
                errorProvider1.SetError(e, "");
            }
        }
    }
}

