using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Areas.Entities.Controllers
{
	[Area("Entities")]
	public class EmployeeController : Controller
    {
	    private readonly IEmployeeService _repository;

	    public EmployeeController(IEmployeeService repository)
	    {
		    _repository = repository;
	    }
	    public IActionResult CreateEmployee(Employee employee)
	    {
			var result = _repository.CreateEmployee(employee);
			ViewBag.CreateResult = result;
		    return View();
	    }
	    public IActionResult GetEmployees()
	    {
		    var employees = _repository.GetEmployees();
		    return View(employees);
	    }
	    public IActionResult UpdateEmployee(Employee employee)
	    {
			var result = _repository.UpdateEmployee(employee);
			ViewBag.UpdateResult = result;
		    return View();
	    }
	    public IActionResult DeleteEmployee(int id)
	    {
			var result = _repository.DeleteEmployee(id);
			ViewBag.DeleteResult = result;
		    return View();
	    }
	}
}
