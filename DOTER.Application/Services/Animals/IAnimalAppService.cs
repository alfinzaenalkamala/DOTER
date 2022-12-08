using DOTER.Application.Helpers;
using DOTER.Application.Services.Animals.Dto;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Animals
{
    public interface IAnimalAppService
    {
        Animal Create(AnimalDto model);
        Animal Update(AnimalUpdateDto model);
        Animal Delete(int id);
        PagedResult<AnimalListDto> GetAllAnimal(PageInfo pageInfo);
    }
}
