using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Electronica.Entity;
using Electronica.Repository;
using Electronica.Manager.ElectronicaDto;

namespace Electronica.Manager.ElectronicaProviders
{
    public class EventManager
    {
        EventDal objEventDal = new EventDal();
        
        public EventDto GetEvent(string eventName)
        {
            Event objEvent = objEventDal.SelectEvent(eventName);
            EventDto objEventDto = new EventDto();
            objEventDto.EventDescription = objEvent.EventDescription;
            return objEventDto;
        }
        public List<EventDto> DisplayEvent()
        {
            List<Event> newList = objEventDal.DisplayEvent();
            List<EventDto> listEventDto = new List<EventDto>();
            EventDto objEventDto = new EventDto();
            foreach (Event item in newList)
            {
                objEventDto = new EventDto();
                objEventDto.EventCreatedBy = item.EventCreatedBy;
                objEventDto.EventDeleteStatus = item.EventDeleteStatus;
                objEventDto.EventDescription = item.EventDescription;
                objEventDto.EventEndDate = item.EventEndDate;
                objEventDto.EventFee = item.EventFee;
                objEventDto.EventID = item.EventID;
                objEventDto.EventIntake = item.EventIntake;
                objEventDto.EventName = item.EventName;
                objEventDto.EventStartDate = item.EventStartDate;
                objEventDto.EventStatus = item.EventStatus;
                objEventDto.LocationID = item.LocationID;
                objEventDto.PromoCode = item.PromoCode;
                objEventDto.PromoDiscount = item.PromoDiscount;
                objEventDto.PromoExpiry = item.PromoExpiry;
                objEventDto.TopicID = item.TopicID;
                listEventDto.Add(objEventDto);
            }
            return listEventDto;
        }
       
            public List<ParticipantEventDto> GetpastEvent(int UserID)
            {
                EventDal ed = new EventDal();
                List<Event> el = ed.GetEvents(UserID);
                //return el;
                List<ParticipantEventDto> elist = new List<ParticipantEventDto>();


                foreach (var item in el)
                {
                    ParticipantEventDto pt = new ParticipantEventDto();
                pt.EventID = item.EventID;
                    pt.EventName = item.EventName;
                    pt.EventStartDate = item.EventStartDate;
                    pt.SpeakerName = "aaaa";
                    elist.Add(pt);
                }
                return elist;
            }
        }

    }

