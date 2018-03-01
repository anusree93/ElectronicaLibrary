using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Electronica.Manager;
using Electronica.Manager.ElectronicaDto;
using Electronica.Manager.ElectronicaProviders;

namespace Electronica_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            

            return View();
        }
        [HttpPost]
        public ActionResult Registration(MemberDto objMemberDto)
        {

            MemberManager objMemberManager = new MemberManager();
            bool status=objMemberManager.AddMember(objMemberDto);
            if (status)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return Content("Error");
            }
        }

        public ActionResult Login()
        {
           return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDto objloginDto)
        {
            LoginManager objLoginManager = new LoginManager();
            if (objLoginManager.CheckLogin(objloginDto))
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("Invalid Username/Password");
            }
        }

    }
        
    }
