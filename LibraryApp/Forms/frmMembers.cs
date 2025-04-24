using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library1Data.Context;

namespace LibraryApp.Forms
{
    public partial class frmMembers : Form
    {
        frmMain frm;

        public frmMembers()
        {
            InitializeComponent();
        }
        private void btnBackToHome_ButtonClick(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
            this.Close();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            dgvMembers.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            BindGrid();
        }
        public void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMembers.AutoGenerateColumns = false;
                dgvMembers.DataSource = db.MemberRepository.GetAll();
                db.Dispose();
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddOrEditMember frmAdd = new frmAddOrEditMember();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvMembers.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        int memberId = int.Parse(dgvMembers.CurrentRow.Cells[0].Value.ToString());
                        db.MemberRepository.Delete(memberId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید");
            }

        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {

            if (dgvMembers.CurrentRow != null)
            {
                int personId = int.Parse(dgvMembers.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditMember frmAddOrEdit = new frmAddOrEditMember();
                frmAddOrEdit.MemberId = personId;
                if (frmAddOrEdit.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilterMember.Text = "";
            BindGrid();
        }

        private void txtFilterMember_TextChanged(object sender, EventArgs e)
        {
            string Parameter = txtFilterMember.Text;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMembers.DataSource = db.MemberRepository.GetAll(f => f.FirstName.Contains(Parameter) ||
                f.LastName.Contains(Parameter) || f.Phone.Contains(Parameter) || f.MembershipDate.Contains(Parameter)
                || f.Email.Contains(Parameter));
                db.Dispose();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm = new frmMain();

            if (frm == null)
            {
                frm.ShowDialog();
            }
            else
            {
                frm.BringToFront();
            }

        }
    }


}
