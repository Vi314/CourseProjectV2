using Entity.Entity;
using MVC.Models.ViewModels;

namespace MVC.Models
{
	public interface IMapper
	{
		public Employee EmployeeMapper(EmployeeDTO dto);
	}
}