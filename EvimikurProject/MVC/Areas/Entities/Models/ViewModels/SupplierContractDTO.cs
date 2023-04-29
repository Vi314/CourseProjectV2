namespace MVC.Areas.Entities.Models.ViewModels
{
    public class SupplierContractDTO:BaseDTO
    {
        public string? SupplierName { get; set; }
        public DateTime? ContractSignDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public DateTime? PaymentDate { get; set; }
        public ContractState? ContractState { get; set; }
        public string? ProductName { get; set; }
        public decimal? Price { get; set; }
        public decimal? ShippingCost { get; set; }
        public int? Amount { get; set; }
    }
}
