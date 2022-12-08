using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Database.Models
{
    [Table("PurchaseDetail")]
    public class PurchaseDetail
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int PurchaseId { get; set; }
        [Required]
        public int AnimalId { get; set; }
        [Required]
        public int Quantity { get; set; }
       
        public virtual Animal? Animal { get; set; }
       public virtual Purchase Purchase { get; set; }
    }
}
