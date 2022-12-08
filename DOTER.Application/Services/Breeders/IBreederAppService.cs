using DOTER.Application.Services.Breeders.Dto;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Breeders
{
    public interface IBreederAppService
    {
        Breeder Create(BreederDto model);
        Breeder Update(BreederUpdateDto model);
    }
    
}
