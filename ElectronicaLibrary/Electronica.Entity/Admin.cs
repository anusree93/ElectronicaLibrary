using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("AdminLogin")]
    public class Admin
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]


        public int AdminId { get; set; }

        [Required]

        public string UserName { get; set; }

        [Required]

        public string Password { get; set; }

        [Required]

        public string AdminName { get; set; }

        [Required]

        public long PhoneNumber { get; set; }

        [Required]

        public string EmailId { get; set; }
    }
}
