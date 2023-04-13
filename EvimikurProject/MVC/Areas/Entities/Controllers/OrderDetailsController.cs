using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	[Area("Entities")]
	public class OrderDetailsController : Controller
	{
		private readonly IOrderDetailsService _repository;

		public OrderDetailsController(IOrderDetailsService repository)
		{
			_repository = repository;
		}
		public IActionResult CreateOrderDetails(OrderDetails orderDetails) //! AN ORDERDETAILS ENTITY MUST BE CONNECTED TO AN ORDER, THIS CHECK IS CURRENTLY NOT IMPLEMENTED
		{
			var result = _repository.CreateOrderDetails(orderDetails);
			ViewBag.CreateResult = result;
			return View();
		}
		public IActionResult GetOrderDetails()
		{
			var orderDetails = _repository.GetOrderDetails();
			return View(orderDetails);
		}
		public IActionResult UpdateOrderDetails(OrderDetails orderDetails)	
		{
			var result = _repository.UpdateOrderDetails(orderDetails);
			ViewBag.UpdateResult = result;
			return View();
		}
		public IActionResult DeleteOrderDetails(int id)
		{
			var result = _repository.DeleteOrderDetails(id);
			ViewBag.DeleteResult = result;
			return View();
		}
	}
}
