using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Repository;
using Electronica.Manager.ElectronicaDto;
using Electronica.Entity;

namespace Electronica.Manager.ElectronicaProviders
{
    public class LoginManager
    {
        public bool CheckLogin(LoginDto objLoginDto)
        {
            bool status=false;
            LoginDal objLoginDal = new LoginDal();
            Login objLogin = new Login();
            objLogin.UserName = objLoginDto.UserName;
            objLogin.Password = objLoginDto.Password;
            status = objLoginDal.CheckLogin(objLogin);
            return status;
        }
    }
}