using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.PurchaseDetails.Dto
{
    public class PurchaseDetailDto
    {
        public int Id { get; set; }
        public int PurchaseId { get; set; }
        public int AnimalId { get; set; }
        public int Quantity { get; set; }
    }
}
