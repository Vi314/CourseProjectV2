using Entity.Entity;
using MVC.Models.ViewModels;

namespace MVC.Models
{
public class Mapper : IMapper
{
	public Employee EmployeeMapper(EmployeeDTO dto)
	{
		var employee = new Employee
		{
			FirstName = dto.FirstName,
			LastName = dto.LastName,
			Department = dto.Department,
			EducationLevel = dto.EducationLevel,
			Title = dto.Title,
			FullAddress = dto.FullAddress
		};

		return employee;
	}
}
}