using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Event")]
    public class Event
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventStartDate { get; set; }
        public DateTime EventEndDate { get; set; }

        [ForeignKey("TopicId")]
        public int EventTopicId { get; set; }
        [ForeignKey("LocationId")]
        public int EventLocationId { get; set; }
        [ForeignKey("SpeakerId")]
        public int EventSpeakerId { get; set; }
        [ForeignKey("PromoId")]
        public int EventPromoId { get; set; }
        public int Fees { get; set; }
        public int Intake { get; set; }
        public int EventStatus { get; set; }
        public string EventDescription { get; set; }
        public int CreatedBy { get; set; }


        //Navigation Properties

        
        public Topic TopicId { get; set; }

        
        public Location LocationId { get; set; }

        
        public SpeakerProfile SpeakerId { get; set; }

        
        public Promo PromoId { get; set; }
    }
}
