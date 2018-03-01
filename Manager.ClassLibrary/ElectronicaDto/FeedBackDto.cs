using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Manager.ElectronicaDto
{
   // [Bind(Exclude = "UserID")]
    public class FeedBackDto
    {
        //public int EnrollId { get; set; }
        //[Scaffold()]
        [ScaffoldColumn(false)]
        public int UserID { get; set; }
        [ScaffoldColumn(false)]
        public int EventID { get; set; }
        public int PresentationSkill { get; set; }

        public int TrainingSkill { get; set; }

        public int SubjectKnowledge { get; set; }
        public int TrainingContent { get; set; }
        public int InteractionSkill { get; set; }

        public string Comments { get; set; }
    }
}
