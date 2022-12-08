using DOTER.Application.Helpers;
using DOTER.Application.Models;
using DOTER.Application.Services.Breeders;
using DOTER.Application.Services.Breeders.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DOTER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreederController : Controller
    {
		private readonly IBreederAppService _breederAppService;
		public BreederController(IBreederAppService breederAppService)
		{
			_breederAppService = breederAppService;
		}
		[HttpPost("CreateBreeder")]
		public IActionResult CreateBreeder([FromBody] BreederDto model)
		{
			try
			{
				var breeder = _breederAppService.Create(model);
				if (breeder == null)
				{
					return Requests.Response(this, new ApiStatus(406), breeder, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), breeder, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}

		[HttpPatch("UpdateBreeder")]
		public IActionResult UpdateBreeder([FromBody] BreederUpdateDto model)
		{
			try
			{
				var breeder = _breederAppService.Update(model);
				if (breeder == null)
				{
					return Requests.Response(this, new ApiStatus(406), breeder, "error");
				}
				return Requests.Response(this, new ApiStatus(200), breeder, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}
	}

}

