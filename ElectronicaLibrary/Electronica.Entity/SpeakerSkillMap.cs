using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("SpeakerSkillMap")]
   public class SpeakerSkillMap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("NavSkill")]
        public int SkillId { get; set; }

        [ForeignKey("NavProfile")]
        public int SpeakerProfileId { get; set; }
        public int Rating { get; set; }
        public Skill NavSkill { get; set; }
        public SpeakerProfile NavProfile { get; set; }

    }
}
