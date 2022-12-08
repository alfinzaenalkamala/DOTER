using AutoMapper;
using DOTER.Application.Services.Breeders.Dto;
using DOTER.Database.Database;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Breeders
{
    public class BreederAppService : IBreederAppService
    {
        private readonly DoterContext _context;
        private readonly IMapper _mapper;
        public BreederAppService(DoterContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public Breeder Create(BreederDto model)
        {
            var breeder = _mapper.Map<Breeder>(model);
            _context.Breeders.Add(breeder);
            _context.SaveChanges();
            return breeder;
        }

        public Breeder Update(BreederUpdateDto model)
        {
            var breeder = _mapper.Map<Breeder>(model);
            _context.Breeders.Update(breeder);
            _context.SaveChanges();
            return breeder;
        }
    }
}

