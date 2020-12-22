using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.DATA.HelperClasses
{
    public class BookHelper
    {
        public void AddBook(string Title, int AuthorId)
        {
            var db = new LibraryEntities();

            Book book = new Book();
            book.Title = Title;
            book.AuthorId = AuthorId;

            db.Books.Add(book);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
