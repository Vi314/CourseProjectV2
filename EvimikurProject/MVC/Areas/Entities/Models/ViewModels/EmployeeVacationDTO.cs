namespace MVC.Areas.Entities.Models.ViewModels
{
	public class EmployeeVacationDTO
	{
		public string? EmployeeName { get; set; }
		public DateTime? VacationStart { get; set; }
		public DateTime? VacationEnd { get; set; }
		public int? VacationDuration { get; set; }
		public bool? IsApproved { get; set; }
	}
}
