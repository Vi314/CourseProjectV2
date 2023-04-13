using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	[Area("Entities")]
	public class DealerStocksController : Controller
	{
		private readonly IDealerStocksService _repository;

		public DealerStocksController(IDealerStocksService repository)
		{
			_repository = repository;
		}
		public IActionResult CreateStock(DealerStocks dealerStocks) //! THE CREATE METHOD FOR CREATING STOCKS HAS TO CHECK IF STOCK ALREADY EXISTS IN THE GIVEN DEALER AND UPDATE THE COUNT IF IT DOES INSTEAD OF CREATE A NEW STOCK
		{
			var result = _repository.CreateDealerStocks(dealerStocks);
			ViewBag.CreateResult = result;
			return View();
		}
		public IActionResult GetStocks()
		{
			var stocks = _repository.GetDealerStocks();
			return View(stocks);
		}
		public IActionResult UpdateStock(DealerStocks dealerStocks) //! THE UPDATE METHOD FOR UPDATING STOCKS HAS TO CHECK IF STOCKS EXIST AND ADD ONTO INSTEAD OF ALTER IF THEY DO
		{
			var result = _repository.UpdateDealerStocks(dealerStocks);
			ViewBag.UpdateResult = result;
			return View();
		}
		public IActionResult DeleteStock(int id)
		{
			var result = _repository.DeleteDealerStocks(id);
			ViewBag.DeleteResult = result;
			return View();
		}
	}
}
