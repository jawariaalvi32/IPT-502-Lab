using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.DATA.HelperClasses
{
    public class AuthorHelper
    {
        public void AddAuthor(String Name)
        {
            var db = new LibraryEntities();

            Author author = new Author();
            author.Name = Name;

            db.Authors.Add(author);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
