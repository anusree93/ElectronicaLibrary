using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Prerequisite")]
    public class Prerequisite
    {
        [Key]
        public int ID { get; set; }
        
        public int EventId { get; set; }
        
        [ForeignKey("NavSpeaker")]
        public int SpeakerProfileID { get; set; }
        
        public string File { get; set; }
        public SpeakerProfile NavSpeaker { get; set; }
        
    }
}
