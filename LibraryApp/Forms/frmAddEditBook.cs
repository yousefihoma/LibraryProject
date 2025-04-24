using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library1Data;
using Library1Data.Context;


namespace LibraryApp.Forms
{
    public partial class frmAddEditBook : Form
    {
        public int bookId = 0;
        UnitOfWork db = new UnitOfWork();
        public int BookId;
        public frmAddEditBook()
        {
            InitializeComponent();
        }
        private void frmAddEditBook_Load(object sender, EventArgs e)
        {
            if (BookId != 0)
            {
                this.Text = "ویرایش کتاب";
                btnAddOrEditBook.Text = "ویرایش";
                var book = db.BookRepository.GetById(BookId);
                txtAuthor.Text = book.Author;
                txtBookTitle.Text = book.Title;
                txtISBN.Text = (book.ISBN).ToString();

            }

        }

        private void btnAddOrEditBook_Click(object sender, EventArgs e)
        {
            if (BookId != 0)
            {
                var book = db.BookRepository.GetById(bookId);
                Books book1 = new Books
                {
                    Title = txtBookTitle.Text,
                    Author = txtAuthor.Text,
                    ISBN = int.Parse(txtISBN.Text)
                };
                if (BookId == 0)
                {
                    db.BookRepository.Insert(book);
                }
                else
                {
                    book.BookID = bookId;
                    db.BookRepository.Update(book);
                }

                db.Save();
                DialogResult = DialogResult.OK;
            }

            else
            {
                RtlMessageBox.Show("لطفا اطلاعات لازم را وارد کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
