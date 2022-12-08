using DOTER.Application.Helpers;
using DOTER.Application.Models;
using DOTER.Application.Services.PurchaseDetails;
using DOTER.Application.Services.PurchaseDetails.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DOTER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseDetailController : Controller
    {
        private readonly IPurchaseDetailAppService _purchaseDetailAppService;
		public PurchaseDetailController(IPurchaseDetailAppService purchaseDetailAppService)
        {
            _purchaseDetailAppService = purchaseDetailAppService;
        }
		[HttpPost("CreatePurchaseDetail")]
		public IActionResult CreatePurchase([FromBody] PurchaseDetailDto model)
		{
			try
			{
				var purchase = _purchaseDetailAppService.Create(model);
				if (purchase == null)
				{
					return Requests.Response(this, new ApiStatus(406), purchase, "Error");
				}
				return Requests.Response(this, new ApiStatus(200), purchase, "Success");
			}
			catch (Exception ex)
			{
				return Requests.Response(this, new ApiStatus(500), null, ex.Message);
			}
		}
		[HttpGet("GetPurchasesDetailById")]
		public IActionResult GetPurchasesById(int Id)
		{
			try
			{
				var data = _purchaseDetailAppService.GetPurchaseDetailById(Id);
				return Requests.Response(this, new ApiStatus(200), data, "");
			}
			catch (Exception ex)
			{

				return Requests.Response(this, new ApiStatus(404), null, ex.Message);

			};

		}
	}
}
