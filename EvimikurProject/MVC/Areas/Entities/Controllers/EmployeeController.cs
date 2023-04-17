using Entity.Entity;
using Logic.Abstract_Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MVC.Models;
using MVC.Models.ViewModels;

namespace MVC.Areas.Entities.Controllers
{
	[Area("Entities")]
	public class EmployeeController : Controller
    {
	    private readonly IEmployeeService _repository;
	    private readonly IMapper _mapper;

	    public EmployeeController(IEmployeeService repository,IMapper mapper)
	    {
		    _repository = repository;
		    _mapper = mapper;
	    }

		public IActionResult CreateEmployee()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateEmployee(EmployeeDTO employeeDTO)
		{
			var employee = _mapper.ToEmployee(employeeDTO);
			var result = _repository.CreateEmployee(employee);
			TempData["Result"] = result;
		    return RedirectToAction("Index");
	    }
		
		public IActionResult Index()  
	    {
		    var employees = _repository.GetEmployees();
		    List<EmployeeDTO> dtoEmployees = new List<EmployeeDTO>();

		    foreach (var emp in employees)
		    {
			    if (emp.State != EntityState.Deleted)
			    {
					dtoEmployees.Add(_mapper.FromEmployee(emp));
				}
		    }

		    return View(dtoEmployees);
	    }
		public IActionResult UpdateEmployee(int id)
		{
			EmployeeDTO employee = new EmployeeDTO();
			foreach (var item in _repository.GetEmployees())
			{
				if (item.Id == id)
				{
					employee = _mapper.FromEmployee(item);
					break;
				}
			}
			return View(employee);
		}
		[HttpPost]
	    public IActionResult UpdateEmployee(EmployeeDTO employeeDTO)
	    {
		    var employee = _mapper.ToEmployee(employeeDTO);
		    var result = _repository.UpdateEmployee(employee);
			TempData["Result"] = result;
		    return RedirectToAction("Index");
	    }
	    public IActionResult DeleteEmployee(int id)
	    {
			var result = _repository.DeleteEmployee(id);
			TempData["Result"] = result;
		    return RedirectToAction("Index");
	    }
	}
}
