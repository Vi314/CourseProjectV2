using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	public class EmployeeVacationController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
