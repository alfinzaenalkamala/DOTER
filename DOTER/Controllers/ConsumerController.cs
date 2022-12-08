using DOTER.Application.Helpers;
using DOTER.Application.Models;
using DOTER.Application.Services.Consumers;
using DOTER.Application.Services.Consumers.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DOTER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumerController : Controller
    {
		private readonly IConsumerAppService _consumerAppService;
		public ConsumerController(IConsumerAppService consumerAppService)
		{
			_consumerAppService = consumerAppService;
		}
		[HttpPost("CreateConsumer")]
		public IActionResult CreateConsumer([FromBody] ConsumerDto model)
		{
			try
			{
				var consumer = _consumerAppService.Create(model);
				if (consumer == null)
				{
					return Requests.Response(this, new ApiStatus(406), consumer, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), consumer, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}

		[HttpPatch("UpdateConsumer")]
		public IActionResult UpdateConsumer([FromBody] ConsumerUpdateDto model)
		{
			try
			{
				var consumer = _consumerAppService.Update(model);
				if (consumer == null)
				{
					return Requests.Response(this, new ApiStatus(406), consumer, "error");
				}
				return Requests.Response(this, new ApiStatus(200), consumer, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}
	}
}
