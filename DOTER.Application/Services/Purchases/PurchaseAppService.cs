using AutoMapper;
using DOTER.Application.Services.Purchases.Dto;
using DOTER.Database.Database;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Purchases
{
    public class PurchaseAppService : IPurchaseAppService
    {
        private readonly DoterContext _context;
        private readonly IMapper _mapper;
        public PurchaseAppService(DoterContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public Purchase Create(PurchaseDto model)
        {
            var purchase = _mapper.Map<Purchase>(model);
            _context.purchases.Add(purchase);
            _context.SaveChanges();
            return purchase;
        }

        public PurchaseListDto GetPurchaseById(int Id)
        {
            var purcahase = _context.purchases.FirstOrDefault(w => w.Id == Id);
            var purchaseDto = _mapper.Map<PurchaseListDto>(purcahase);
            return purchaseDto;
        }
    }
}
