using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	[Area("Entities")]
	public class CategoryController : Controller
	{
		private readonly IEmployeeService _service;

		public CategoryController(IEmployeeService service)
		{
			_service = service;
		}
		public IActionResult CreateCategory(Employee employee)
		{
		 	var result = _service.CreateEmployee(employee);
			ViewBag.CreateResult = result;
			return View();
		}
		public IActionResult GetCategories()
		{
			var employees = _service.GetEmployees();
			return View(employees);
		}
		public IActionResult UpdateCategory(Employee employee)
		{
			var result = _service.UpdateEmployee(employee);
			ViewBag.UpdateResult = result;
			return View();
		}
		public IActionResult DeleteCategory(int id)
		{
			var result = _service.DeleteEmployee(id);
			ViewBag.DeleteResult = result;
			return View();
		}
	}
}
