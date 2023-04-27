using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
    [Area("Entities")]
    public class SupplierContractDetailsController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
