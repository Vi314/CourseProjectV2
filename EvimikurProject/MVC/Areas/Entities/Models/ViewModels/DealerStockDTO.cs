namespace MVC.Areas.Entities.Models.ViewModels
{
	public class DealerStockDTO:BaseDTO
	{
		public string? DealerName { get; set; }
		public string? ProductName { get; set; }
		public int? Amount { get; set; }
	}
}
