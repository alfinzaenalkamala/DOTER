using AutoMapper;
using DOTER.Application.Services.Consumers.Dto;
using DOTER.Database.Database;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Consumers
{
    public class ConsumerAppService : IConsumerAppService
    {
        private readonly DoterContext _context;
        private readonly IMapper _mapper;
        public ConsumerAppService(DoterContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public Consumer Create(ConsumerDto model)
        {
            var consumer = _mapper.Map<Consumer>(model);
            _context.Consumers.Add(consumer);
            _context.SaveChanges();
            return consumer;
        }

        public Consumer Update(ConsumerUpdateDto model)
        {
            var consumer = _mapper.Map<Consumer>(model);
            _context.Consumers.Update(consumer);
            _context.SaveChanges();
            return consumer;
        }
    }
}
