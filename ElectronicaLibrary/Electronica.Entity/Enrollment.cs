using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;
using System.Data.Entity;


namespace Electronica.Entity
{
    [Table("Enrollment")]
    public class Enrollment
    {
        [Key]
        [Column(Order = 1)]
        public int EnrollId { get; set; }
        [Column(Order = 2)]
        [ForeignKey("EventId")]
        public int EnrollEventId { get; set; }
        public Event EventId { get; set; } 

        [Column(Order = 3)]
        [ForeignKey("MemberId")]
        public int EnrollMemberId { get; set; }
        public Member MemberId { get; set; }


        [Column(Order =4)]
        
        public Boolean PaymentStatus { get; set; }
        [Column(Order =5)]
        public int Skill1 { get; set; }
        [Column(Order = 6)]
        public int Skill2 { get; set; }
        [Column(Order = 7)]
        public int Skill3 { get; set; }
        [Column(Order =8)]
        public string Comments { get; set; }
    }
}
