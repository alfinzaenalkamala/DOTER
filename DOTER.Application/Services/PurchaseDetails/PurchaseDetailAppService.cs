using AutoMapper;
using DOTER.Application.Services.PurchaseDetails.Dto;

using DOTER.Database.Database;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.PurchaseDetails
{
    public class PurchaseDetailAppService : IPurchaseDetailAppService
    {
        private readonly DoterContext _context;
        private readonly IMapper _mapper;
        public PurchaseDetailAppService(DoterContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
      

        public PurchaseDetail Create(PurchaseDetailDto model)
        {
            var purchasedetail = _mapper.Map<PurchaseDetail>(model);
            _context.purchaseDetails.Add(purchasedetail);
            _context.SaveChanges();
            return purchasedetail;
        }

        public PuchaseDetailListDto GetPurchaseDetailById(int Id)
        {
            var purchasedetail = _context.purchases.FirstOrDefault(w => w.Id == Id);
            var purchasedetailDto = _mapper.Map<PuchaseDetailListDto>(purchasedetail);
            return purchasedetailDto;
        }
    }
}
