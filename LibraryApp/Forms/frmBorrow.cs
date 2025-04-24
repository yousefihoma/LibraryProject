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
using LibraryModel;
using Library1Data.Context;
namespace LibraryApp.Forms
{
    public partial class frmBorrow : Form
    {
        public frmBorrow()
        {
            InitializeComponent();
        }
        private void frmBorrow_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                //List<ListMemberViewModel> list = new List<ListMemberViewModel>();
                //list.Add(new ListMemberViewModel()
                //{
                //    MemberID = 0,
                //    Name = "انتخاب کنید"
                //});
                //list.Add(db.MemberRepository.GetAll());
 
               //  cmbMemberName.DataSource = list;
                cmbMemberName.DataSource = db.MemberRepository.GetAll();
                cmbMemberName.DisplayMember = "Name";
                cmbMemberName.ValueMember = "MemberID";
                db.Dispose();
            }

            lblTodayDate.Text = Convertor.ToShamsi(DateTime.Now);
        }
        private void btnSelectBooks_Click(object sender, EventArgs e)
        {

        }
    }
}
