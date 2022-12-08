using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Database.Models
{
    [Table("Breeder")]
    public class Breeder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [StringLength(15)]
        public string? PhoneNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string? Address{ get; set; }
      
        public virtual ICollection<Animal>? Animals { get; set; }
        public virtual ICollection<Purchase>? Purchase { get; set; }
    }
}
