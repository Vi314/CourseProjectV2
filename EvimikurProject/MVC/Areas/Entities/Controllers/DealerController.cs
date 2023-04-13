
using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
    [Area("Entities")]
    public class DealerController : Controller
    {
	    private readonly IDealerService _service;

	    public DealerController(IDealerService service)
	    {
		    _service = service;
	    }

	    public IActionResult CreateDealer(Dealer dealer)
	    {
			var result = _service.CreateDealer(dealer);
			ViewBag.CreateResult = result;
		    return View();
	    }
	    public IActionResult GetDealers()
	    {
			var dealers = _service.GetDealers();
		    return View(dealers);
	    }
	    public IActionResult UpdateDealer(Dealer dealer)
	    {
			var result = _service.UpdateDealer(dealer);	
			ViewBag.UpdateResult = result;
		    return View();
	    }
	    public IActionResult DeleteDealer(int id)
	    {
			var result = _service.DeleteDealer(id);
			ViewBag.DeleteResult = result;
		    return View();
	    }
	}
}
