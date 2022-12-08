using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Database.Models
{
    [Table("Purchase")]
    public class Purchase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int ConsumerId { get; set; }
        [Required]
        public int BreederId { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public virtual Consumer? Consumer { get; set; }
        public virtual Breeder? Breeder{ get; set; }
        public virtual ICollection<PurchaseDetail>? PurchaseDetails { get; set; }


    }
}
