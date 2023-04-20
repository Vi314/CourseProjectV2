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
	    private readonly IEmployeeService _service;
	    private readonly IDistrictService _districtService;
	    private readonly IDealerService _dealerService;
	    private readonly IMapper _mapper;

	    public EmployeeController(IEmployeeService service,IDistrictService districtService,IDealerService dealerService,IMapper mapper)
	    {
		    _service = service;
		    _districtService = districtService;
		    _dealerService = dealerService;
		    _mapper = mapper;
	    }

		public IActionResult CreateEmployee()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateEmployee(EmployeeDTO employeeDTO)
		{
			var dealers = _dealerService.GetDealers().ToList();
			var employee = _mapper.ToEmployee(employeeDTO, dealers);
			var result = _service.CreateEmployee(employee);
			ViewBag.Dealers = dealers;
			TempData["Result"] = result;
		    return RedirectToAction("Index");
	    }
		
		public IActionResult Index()  
	    {
		    var employees = _service.GetEmployees();
		    var dealers = _dealerService.GetDealers().ToList();
		    List<EmployeeDTO> dtoEmployees = new List<EmployeeDTO>();

		    foreach (var emp in employees)
		    {
			    if (emp.State != EntityState.Deleted)
			    {
					dtoEmployees.Add(_mapper.FromEmployee(emp,dealers));
				}
		    }

		    return View(dtoEmployees);
	    }
		public IActionResult UpdateEmployee(int id)
		{
			var dealers = _dealerService.GetDealers().ToList();
			EmployeeDTO employee = new EmployeeDTO();
			foreach (var item in _service.GetEmployees())
			{
				if (item.Id == id)
				{
					employee = _mapper.FromEmployee(item, dealers);
					break;
				}
			}
			ViewBag.Dealers = dealers;
			return View(employee);
		}
		[HttpPost]
	    public IActionResult UpdateEmployee(EmployeeDTO employeeDTO)
	    {
		    var dealers = _dealerService.GetDealers().ToList();
			var employee = _mapper.ToEmployee(employeeDTO, dealers);
		    var result = _service.UpdateEmployee(employee);
			TempData["Result"] = result;
		    return RedirectToAction("Index");
	    }
	    public IActionResult DeleteEmployee(int id)
	    {
			var result = _service.DeleteEmployee(id);
			TempData["Result"] = result;
		    return RedirectToAction("Index");
	    }
	}
}
