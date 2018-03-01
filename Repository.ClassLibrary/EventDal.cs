using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;

namespace Electronica.Repository
{
    public class EventDal
    {
        ElectronicaContext context = new ElectronicaContext();
        public Event SelectEvent(string eventName)
        {
            List<Event> eventList = context.Events.ToList();
            Event objEvent = eventList.Find(p => p.EventName == eventName);
            return objEvent;
        }
        public List<Event> DisplayEvent()
        {
            List<Event> eventList = context.Events.ToList();

            return eventList;
        }
        public List<Event> GetEvents(int UserID)
        {
            
            List<Event> eList = new List<Event>();
            List<ParticipantEnrollment> pl = context.ParticipantEnrollments.ToList();
            List<ParticipantEnrollment> res = pl.FindAll(t => t.UserID == UserID);
            //car res
            //var res = from temp in context.ParticipantEnrollments where temp.UserID == UserID select temp;
            foreach (var item in res)
            {
                var ev = context.Events.Where(p => p.EventID == item.EventID).Single();
                 eList.Add(ev);


            }
            //List<ParticipantEnrollment> pl = context.ParticipantEnrollments.ToList();
            //var el=pl.Find(p => p.UserID == UserID);
            //events.
            //foreach (var item in el)
            //{
            //    var ev = context.Events.Where(p => p.EventID == item.EventID).Single();
            //    eList.Add(ev);
            //}
            return eList;
        }

    }
}
