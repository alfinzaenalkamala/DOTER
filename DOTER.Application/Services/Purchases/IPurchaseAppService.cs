using DOTER.Application.Services.Purchases.Dto;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Purchases
{
   public interface IPurchaseAppService
    {
        Purchase Create(PurchaseDto model);
        PurchaseListDto GetPurchaseById(int Id);
    }
}
