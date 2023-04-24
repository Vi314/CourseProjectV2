namespace MVC.Areas.Entities.Models.ViewModels
{
    public class SupplierDTO:BaseDTO
    {
        public string? CompanyName { get; set; }
        public int? SupplierGrade { get; set; }
        public bool? IsEligible { get; set; }
    }
}
