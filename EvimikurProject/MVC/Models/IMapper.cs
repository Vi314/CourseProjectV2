using Entity.Entity;
using MVC.Models.ViewModels;

namespace MVC.Models
{
	public interface IMapper
	{
		public Employee ToEmployee(EmployeeDTO dto);
		public EmployeeDTO FromEmployee(Employee entity);

	}
}