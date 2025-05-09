using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library1Data.Context;
using LibraryApp.Forms;

namespace LibraryApp
{
    internal static class Program
    {
        public static int? CurrentUserId = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var repo = new UnitOfWork())
            {
                var items = repo.BorrowRepository.GetAllAsQueryable().Include(r => r.Books).Include(r => r.Members);
                //select * From borrow left join books on bookid =  boorow.bookid left join member ...
                // select member.memberid, book.bookid, book.title from ..^
                var data = items.Select(r => new 
                {
                    MemberId = r.Members.MemberID,
                    BookId = r.Books.BookID,
                    BookName = r.Books.Title
                }).ToList();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            var loginForm = new frmLogin();
            Application.Run(loginForm);
            if (loginForm.DialogResult == DialogResult.OK)
            {
                Application.Run(new frmMain());

            }
            //Application.Run(new frmMembers());
            // Application.Run(new frmBorrow());
            //Application.Run(new frmBook());
            //  Application.Run(new frmAddOrEditMember());

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show(((Exception)(e.ExceptionObject)).Message);

        }

        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message);
        }
    }
}
