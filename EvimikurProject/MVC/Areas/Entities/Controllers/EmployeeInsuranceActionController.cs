using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	public class EmployeeInsuranceActionController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
