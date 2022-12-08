using DOTER.Application.Helpers;
using DOTER.Application.Models;
using DOTER.Application.Services.Purchases;
using DOTER.Application.Services.Purchases.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DOTER.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : Controller
    {
		private readonly IPurchaseAppService _purchaseAppService;
		public PurchaseController (IPurchaseAppService purchaseAppService)
		{
			_purchaseAppService = purchaseAppService;
		}
		[HttpPost("CreatePurchase")]
		public IActionResult CreatePurchase([FromBody] PurchaseDto model)
		{
			try
			{
				var purchase = _purchaseAppService.Create(model);
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
		[HttpGet("GetPurchasesById")]
		public IActionResult GetPurchasesById(int Id)
		{
			try
			{
				var data =_purchaseAppService.GetPurchaseById(Id);
				return Requests.Response(this, new ApiStatus(200), data, "");
			}
			catch (Exception ex)
			{

				return Requests.Response(this, new ApiStatus(404), null, ex.Message);

			};

		}
	}
}
