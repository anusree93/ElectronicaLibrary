using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Electronica.Entity
{

    [Table("Member")]
    public class Member
    {
        
        [Key]
        [Column(Order = 1)]
        public int MemberId { get; set; }

        [Required]
        [Column(Order = 2)]
        public string MemberFirstName { get; set; }

        [Required]
        [Column(Order = 3)]
        public string MemberLastName { get; set; }

        [Required]
        [Column(Order = 4)]
        public string MemberEmail { get; set; }

        [Required]
        [Column(Order = 5)]
        public string MemberPassword { get; set; }

        [Required]
        [Column(Order = 6)]
        public string MemberEducation { get; set; }

        [Required]
        [Column(Order = 7)]       
        public int MemberContact { get; set; }

        [Column(Order = 8)]
        public byte[] MemberImage { get; set; }


    }
}
