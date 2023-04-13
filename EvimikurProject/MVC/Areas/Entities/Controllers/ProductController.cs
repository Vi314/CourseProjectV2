using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	[Area("Entities")]
	public class ProductController : Controller
    {
	    private readonly IProductService _repository;

	    public ProductController(IProductService repository)
	    {
		    _repository = repository;
	    }
		public IActionResult CreateProduct(Product product)
		{
			var result = _repository.CreateProduct(product);
			ViewBag.CreateResult = result;
			return View();
		}
		public IActionResult GetProducts()
		{
			var products = _repository.GetProducts();
			return View(products);
		}
		public IActionResult Update(Product product)
		{
			var result = _repository.UpdateProduct(product);
			ViewBag.UpdateResult = result;
			return View();
		}
		public IActionResult Delete(int id )
		{
			var result = _repository.DeleteProduct(id);
			ViewBag.DeleteResult = result;
			return View();
		}
	}
}
