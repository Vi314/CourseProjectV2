using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	public class EmployeeEntryExitController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
