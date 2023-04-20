﻿using Entity.Entity;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MVC.Models.ViewModels;

namespace MVC.Models
{
	public class Mapper : IMapper
	{
		public Employee ToEmployee(EmployeeDTO dto, List<Dealer> dealers)
		{
			var employee = new Employee
			{
				Id = dto.Id,
				FirstName = dto.FirstName,
				LastName = dto.LastName,
				Department = dto.Department,
				EducationLevel = dto.EducationLevel,
				Title = dto.Title,
				FullAddress = dto.FullAddress,
				DealerId = dealers.Where(x => x.Name == dto.Dealer).Select(x => x.Id).FirstOrDefault()
			};
			return employee;
		}
		public EmployeeDTO FromEmployee(Employee entity, List<Dealer> dealers)
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

			if (entity.DealerId != null)
			{
				employeeDTO.Dealer = dealers.Where(x => x.Id == entity.DealerId).Select(x => x.Name).FirstOrDefault()
					.ToString();
			}

			return employeeDTO;
		}
	}
}
