using AutoMapper;
using DOTER.Application.Helpers;
using DOTER.Application.Services.Animals.Dto;
using DOTER.Database.Database;
using DOTER.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTER.Application.Services.Animals
{
    public class AnimalAppService : IAnimalAppService
    {
        private readonly DoterContext _context;
        private readonly IMapper _mapper;
        public AnimalAppService(DoterContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public Animal Create(AnimalDto model)
        {
            var animal = _mapper.Map<Animal>(model);
            _context.Animals.Add(animal);
            _context.SaveChanges();
            return animal;
        }

        public Animal Delete(int id)
        {
            var animal = _context.Animals.FirstOrDefault(w => w.Id == id);
            _context.Animals.Remove(animal);
            _context.SaveChanges();

            return animal;
        }

        public Animal Update(AnimalUpdateDto model)
        {
            var animal= _mapper.Map<Animal>(model);
            _context.Animals.Update(animal);
            _context.SaveChanges();

            return animal;
        }
        public PagedResult<AnimalListDto> GetAllAnimal(PageInfo pageInfo)
        {
            var pagedResult = new PagedResult<AnimalListDto>
            {
                Data = (from Animal in _context.Animals
                        join Breeder in _context.Breeders
                        on Animal.BreederId equals Breeder.Id
                       
                        select new AnimalListDto
                        {
                            Id = Animal.Id,
                            AnimalName = Animal.AnimalName,
                            Age = Animal.age,
                            Description = Animal.Description,
                            Price = Animal.Price,
                            BreederName = Breeder.Name,
                            Address= Breeder.Address
                        }).Skip(pageInfo.Skip)
                .Take(pageInfo.PageSize)
                .OrderBy(w => w.Id),
                Total = _context.Animals.Count()
            };

            return pagedResult;
        }
    }
}
