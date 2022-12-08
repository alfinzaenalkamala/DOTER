using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Purchases.Dto
{
    public class PurchaseListDto
    {
        public int Id { get; set; }
        public int ConsumerId { get; set; }
        public int BreederId { get; set; }
        public DateTime DateTime { get; set; }
    }
}
