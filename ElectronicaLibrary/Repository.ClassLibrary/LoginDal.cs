using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Repository
{
   public class LoginDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public bool CheckLogin(Login loginObj)
        {
            bool status = false;
            Login objLogin = context.Logins.Find(loginObj.UserName);
            if (objLogin.Password==loginObj.Password)
            {
                status= true;
            }
            return status;
        }
    }
}
