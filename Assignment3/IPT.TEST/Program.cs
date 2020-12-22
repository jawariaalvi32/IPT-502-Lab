using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPT.DATA.HelperClasses;

namespace IPT.TEST
{
    public class Program
    {
        public static void Main()
        {
            MemberHelper memberHelper = new MemberHelper();
            memberHelper.AddMember("Maryam", "Airport", 033267888);
            AuthorHelper authorHelper = new AuthorHelper();
            authorHelper.AddAuthor("Mark Ryan");
            BookHelper bookHelper = new BookHelper();
            bookHelper.AddBook("Calculus", 3);
            BookIssueHelper bookIssueHelper = new BookIssueHelper();
            bookIssueHelper.AddBookIssue("23-12-2020", 2, 3);
        }
    }
}
