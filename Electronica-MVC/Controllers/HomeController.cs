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
        public ActionResult Registration(ParticipantDto objMemberDto)
        {

            ParticipantManager objMemberManager = new ParticipantManager();
            bool status=objMemberManager.AddParticipant(objMemberDto);

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
            string s = null;
            try
            {



                LoginManager objLoginManager = new LoginManager();
                ParticipantDto objReturn = new ParticipantDto();
                objReturn=objLoginManager.CheckLogin(objloginDto);
                if (objReturn.Email!=null)
                   {
                    Session["Uid"] = objReturn.UserID;
                    Session["UserName"] = objReturn.FirstName + " " + objReturn.LastName;
                    return RedirectToAction("Index");
                   }
                else
                    {
                    return Content("Invalid Username/Password");
                    }
            }
            catch (Exception ex)
            {
                s = ex.Message;
                s += ex.Source;
                s += ex.InnerException.Message;
            }
            return Content(s);
        }
        public ActionResult PastEvents()
        {
            //int UserID = Convert.ToInt32(Session["Uid"]);
            int UserID = 1;
            EventManager em = new EventManager();
            List<ParticipantEventDto> pd = em.GetpastEvent(UserID);
            ViewBag.el = pd;
            return View();
        }
        public ActionResult Feedback1()
        {
            return View();
        }
        [HttpPost]
            public ActionResult Feedback1(FeedBackDto fd)
        {
            fd.UserID = 2;
            fd.EventID = 6;

            FeedbackManager fm = new FeedbackManager();
            fm.UpdateFeedback(fd);
            return Content("Feedback Submitted ");
        }

        public ActionResult Enrollment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Enrollment(EnrollmentDto objEnrollmentDto)
        {
            return RedirectToAction("ShowEvent");
        }
        
        public ActionResult GetEvent(string eventName)
        { 
            EventManager objEvent = new EventManager();
            EventDto objEventDto = new EventDto();
            objEventDto=objEvent.GetEvent(eventName);
            ViewBag.Name = objEventDto.EventName;
            ViewBag.StartDate= objEventDto.EventStartDate;
            ViewBag.Status=objEventDto.EventStatus;
            ViewBag.Promocode = objEventDto.PromoCode;
            return View("SearchResults");
                
        }
        public ActionResult ShowEvent()
        {
            EventManager objEvent = new EventManager();
            List<EventDto> newEventList = new List<EventDto>();
            newEventList = objEvent.DisplayEvent();
            var model = new List<EventDto>();
            foreach (EventDto item in newEventList)
            {
                model.Add(item);
            }
            return View(model);
         
        }
    }
        
}
