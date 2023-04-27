using Entity.Entity;
using MVC.Areas.Entities.Models.MapperAbstract;
using MVC.Areas.Entities.Models.ViewModels;

namespace MVC.Areas.Entities.Models.MapperConcrete
{
    public class SupplierContractMapper:ISupplierContractMapper
    {
        public SupplierContract ToSupplierContract(SupplierContractDTO supplierContractDTO, IEnumerable<Supplier> suppliers)
        {
            SupplierContract supplierContract = new SupplierContract
            {
                Id = supplierContractDTO.Id,
                ContractSignDate = supplierContractDTO.ContractSignDate,
                ContractEndDate = supplierContractDTO.ContractEndDate,
                PaymentDate = supplierContractDTO.PaymentDate
            };
            supplierContract.SupplierId = suppliers.Where(x => x.CompanyName == supplierContractDTO.SupplierName)
                .Select(x => x.Id).FirstOrDefault();
            return supplierContract;
        }

        public SupplierContractDTO FromSupplierContract(SupplierContract supplierContract, IEnumerable<Supplier> suppliers)
        {
            SupplierContractDTO supplierContractDTO = new SupplierContractDTO
            {
                Id = supplierContract.Id,
                ContractSignDate = supplierContract.ContractSignDate,
                ContractEndDate = supplierContract.ContractEndDate,
                PaymentDate = supplierContract.PaymentDate
            };
            if (supplierContract.SupplierId != null)
            {
                supplierContractDTO.SupplierName = suppliers.Where(x => x.Id == supplierContract.SupplierId)
                    .Select(x => x.CompanyName).FirstOrDefault();
            }
            return supplierContractDTO;
        }
    }
}
