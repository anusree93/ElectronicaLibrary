using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
namespace Electronica.Repository
{
    public class MemberDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public bool InsertMember(Member objMember,Login objLogin)
        {
            //context.Database.Delete();
            //context.Database.Create();
            context.Members.Add(objMember);
            context.Logins.Add(objLogin);
            context.SaveChanges();
            return true;
        }
    }
}
