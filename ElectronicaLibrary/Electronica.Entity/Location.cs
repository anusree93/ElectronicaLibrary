using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Location")]
    public partial class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }
        [Required]
        public string LocationName { get; set; }
        [Required]
        public string BuildingNo { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Pin { get; set; }
        [Required]
        public string LandMark { get; set; }
        [Required]
        public int SeatCapacity { get; set; }
        [Required]
        public int Ac { get; set; }
        [Required]
        public int LocationStatus { get; set; }
        [Required]
        public byte Image { get; set; }

    }
}
