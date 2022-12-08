using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Animals.Dto
{
   public class AnimalUpdateDto
    {
        public int Id { get; set; }
        public string? AnimalName { get; set; }
        public string? Age { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public int BreederId { get; set; }
    }
}
