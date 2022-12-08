using AutoMapper;
using DOTER.Application.Services.Animals.Dto;
using DOTER.Application.Services.Breeders.Dto;
using DOTER.Application.Services.Consumers.Dto;
using DOTER.Application.Services.PurchaseDetails.Dto;
using DOTER.Application.Services.Purchases.Dto;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Config
{
   public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            // Animal
            CreateMap<AnimalDto, Animal>();
            CreateMap<Animal, AnimalDto>();
            CreateMap<AnimalUpdateDto, Animal>();
            CreateMap<Animal, AnimalUpdateDto>();
            // Consumer
            CreateMap<ConsumerDto, Consumer>();
            CreateMap<Consumer, ConsumerDto>();
            CreateMap<ConsumerUpdateDto, Consumer>();
            CreateMap<Consumer, ConsumerUpdateDto>();
            // Breeder
            CreateMap<BreederDto, Breeder>();
            CreateMap<Breeder, BreederDto>();
            CreateMap<BreederUpdateDto, Breeder>();
            CreateMap<Breeder, BreederUpdateDto>();
            // Purchase
            CreateMap<PurchaseDto, Purchase>();
            CreateMap<Purchase, PurchaseDto>();
            CreateMap<PurchaseListDto, Purchase>();
            CreateMap<Purchase, PurchaseListDto>();
            // PurchaseDetail
            CreateMap<PurchaseDetailDto, PurchaseDetail>();
            CreateMap<PurchaseDetail, PurchaseDetailDto>();
            CreateMap<PuchaseDetailListDto, PurchaseDetail>();
            CreateMap<PurchaseDetail, PuchaseDetailListDto>();


        }
    }
}
