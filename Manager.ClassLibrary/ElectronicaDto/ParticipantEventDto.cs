using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Manager.ElectronicaDto
{
    public class ParticipantEventDto
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public string SpeakerName { get; set; }
        public DateTime EventStartDate { get; set; }
    }

}
