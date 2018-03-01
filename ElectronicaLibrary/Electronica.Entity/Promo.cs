using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electronica.Entity
{
    [Table("Promo")]
    public class Promo

    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int PromoId { get; set; }
        [Required]
        public string PromoCode { get; set; }
        [Required]
        public DateTime PromoExpiry { get; set; }
        [Required]
        public int PromoDiscount { get; set; }
    }
}
