using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	[Area("Entities")]
	public class OrderController : Controller
	{
		private readonly IOrderService _repository;

		public OrderController(IOrderService repository)
		{
			_repository = repository;
		}
		public IActionResult CreateOrder(Order order)
		{
			var result = _repository.CreateOrder(order);
			ViewBag.CreateResult = result;
			return View();
		}
		public IActionResult GetOrders()
		{
			var orders = _repository.GetOrders();
			return View(orders);
		}
		public IActionResult UpdateOrder(Order order)
		{
			var result = _repository.UpdateOrder(order);
			ViewBag.UpdateResult = result;
			return View();
		}
		public IActionResult DeleteOrder(int id)
		{
			var result = _repository.DeleteOrder(id);
			ViewBag.DeleteResult = result;
			return View();
		}
	}
}
