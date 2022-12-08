using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Database.Models
{
    [Table("Consumer")]
    public class Consumer
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
        public virtual ICollection<Purchase>? Purchase { get; set; }
    }
}
