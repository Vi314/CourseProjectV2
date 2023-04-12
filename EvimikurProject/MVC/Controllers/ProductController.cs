using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
