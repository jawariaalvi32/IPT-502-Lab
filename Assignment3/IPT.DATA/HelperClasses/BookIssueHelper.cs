using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.DATA.HelperClasses
{
    public class BookIssueHelper
    {
        public void AddBookIssue(string IssueDate, int MemberId, int BookId)
        {
            var db = new LibraryEntities();

            BookIssue book = new BookIssue();
            book.IssueDate = IssueDate;
            book.MemberId = MemberId;
            book.BookId = BookId;

            db.BookIssues.Add(book);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
