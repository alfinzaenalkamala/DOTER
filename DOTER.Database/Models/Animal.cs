using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Database.Models
{
    [Table("Animal")]
    public class Animal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? AnimalName { get; set; }
        [Required]
        [StringLength(10)]
        public string? age { get; set; }
        [Required]
        [StringLength(200)]
        public string? Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int BreederId { get; set; }
        public virtual Breeder? Breeder { get; set; }
        public virtual ICollection<PurchaseDetail>? PurchaseDetails { get; set; }




    }
}
