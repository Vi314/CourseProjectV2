using Entity.Entity;
using Microsoft.EntityFrameworkCore;
using MVC.Models.ViewModels;

namespace MVC.Models
{
	public class Mapper : IMapper
	{
		public Employee ToEmployee(EmployeeDTO dto)
		{
			var employee = new Employee
			{
				Id = dto.Id,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Department = dto.Department,
				EducationLevel = dto.EducationLevel,
				Title = dto.Title,
				FullAddress = dto.FullAddress
			};
			return employee;
		}
		public EmployeeDTO FromEmployee(Employee entity)
		{
			var employeeDTO = new EmployeeDTO
			{
				Id = entity.Id,
				FirstName = entity.FirstName,
				LastName = entity.LastName,
				Department = entity.Department,
				EducationLevel = entity.EducationLevel,
				Title = entity.Title,
				FullAddress = entity.FullAddress
			};
			return employeeDTO;

		}
	}
}
