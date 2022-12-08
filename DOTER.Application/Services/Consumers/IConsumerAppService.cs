
using DOTER.Application.Services.Consumers.Dto;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Consumers
{
   public interface IConsumerAppService
    {
        Consumer Create(ConsumerDto model);
        Consumer Update(ConsumerUpdateDto model);
    }
}
