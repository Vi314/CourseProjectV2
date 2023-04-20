using System.ComponentModel;
using Entity.Entity;

namespace MVC.Models.ViewModels
{
	public class EmployeeDTO
	{
		public int Id { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? Department { get; set; }
		public string? EducationLevel { get; set; }
		public string? FullAddress { get; set; }
		public string? Title { get; set; }
		public string? Dealer { get; set; }   = "";
		public string? District { get; set; }  
		public string? City { get; set; }     
		public string? Country { get; set; }  

	}
}
