using Library1Data.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApp.Forms
{
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            dgvBook.AlternatingRowsDefaultCellStyle.BackColor = Color.Pink;
            BindGrid();
        }
        public void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvBook.AutoGenerateColumns = false;
                dgvBook.DataSource = db.BookRepository.GetAll();
                db.Dispose();
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgvBook.CurrentRow.Cells[1].Value.ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمئن هستید ؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        int memberId = int.Parse(dgvBook.CurrentRow.Cells[0].Value.ToString());
                        db.BookRepository.Delete(memberId);
                        db.Save();
                        BindGrid();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک کتاب را انتخاب کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBook.CurrentRow != null)
            {
                int bookId = int.Parse(dgvBook.CurrentRow.Cells[0].Value.ToString());
                frmAddEditBook frmAddEditBook = new frmAddEditBook();
                frmAddEditBook.BookId = bookId;
                if (frmAddEditBook.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }


        }

        private void btnRefreshBook_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtFilterBook_TextChanged(object sender, EventArgs e)
        {
            string Parameter = txtFilterBook.Text;
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvBook.DataSource = db.BookRepository.GetAll(f => f.Title.Contains(Parameter) ||
                f.Publisher.Contains(Parameter) || f.Author.Contains(Parameter));
                db.Dispose();
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddEditBook frmAddEditBook = new frmAddEditBook();
            if (frmAddEditBook.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }

        }
    }
}
