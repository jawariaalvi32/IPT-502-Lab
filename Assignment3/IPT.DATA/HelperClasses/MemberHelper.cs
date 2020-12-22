using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPT.DATA.HelperClasses
{
    public class MemberHelper
    {
        public void AddMember(String Name, String Address, int ContactNo)
        {
            var db = new LibraryEntities();

            Member mb = new Member();
            mb.Name = Name;
            mb.Address = Address;
            mb.ContactNo = ContactNo;

            db.Members.Add(mb);
            db.SaveChanges();
            db.Dispose();
        }
    }
}
