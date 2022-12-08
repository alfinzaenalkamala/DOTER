using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Animals.Dto
{
    public class AnimalListDto
    {
        public int Id { get; set; }
        public string? AnimalName { get; set; }
        public string? Age { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public string? BreederName { get; set; }
        public string? Address { get; set; }
    }
}
