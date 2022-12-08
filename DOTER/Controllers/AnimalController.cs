using DOTER.Application.Helpers;
using DOTER.Application.Models;
using DOTER.Application.Services.Animals;
using DOTER.Application.Services.Animals.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DOTER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : Controller
    {
		private readonly IAnimalAppService _animalAppService;
		public AnimalController(IAnimalAppService animalAppService)
		{
			_animalAppService = animalAppService;
		}

		[HttpGet("GetAllField")]
		[Produces("application/json")]
		public IActionResult GetAllAnimal([FromQuery] PageInfo pageInfo)
		{
			try
			{
				var animalList = _animalAppService.GetAllAnimal(pageInfo);
				return Requests.Response(this, new ApiStatus(200), animalList, "");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(404), null, ex.Message);
			}
		}

		[HttpPost("Create")]
		public IActionResult Create([FromBody] AnimalDto model)
		{
			try
			{
				var animal = _animalAppService.Create(model);
				if (animal == null)
				{
					return Requests.Response(this, new ApiStatus(406), animal, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), animal, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}

		[HttpPatch("Edit")]
		public IActionResult Edit([FromBody] AnimalUpdateDto model)
		{
			try
			{
				var animal = _animalAppService.Update(model);
				if (animal == null)
				{
					return Requests.Response(this, new ApiStatus(406), animal, "error");
				}
				return Requests.Response(this, new ApiStatus(200), animal, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}

		[HttpDelete("Delete")]
		public IActionResult Delete(int id)
		{
			try
			{
				var animal = _animalAppService.Delete(id);
				if (animal == null)
				{
					return Requests.Response(this, new ApiStatus(406), animal, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), animal, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}
	}
}
