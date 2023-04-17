using Entity.Entity;

namespace MVC.Models.ViewModels
{
	public class EmployeeDTO
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Department { get; set; }
		public string EducationLevel { get; set; }
		public string FullAddress { get; set; }
		public string Title { get; set; }
		public District District { get; set; }
	
	}
}
