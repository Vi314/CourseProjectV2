using Entity.Entity;

namespace Logic.Abstract_Service;

public interface ISupplierContractDetailsService
{
	string CreateSupplierContractDetails(SupplierContractDetails supplierContractDetails);
	string UpdateSupplierContractDetails(SupplierContractDetails supplierContractDetails);
	string DeleteSupplierContractDetails(int id);
	IEnumerable<SupplierContractDetails> GetSupplierContractDetails();
	SupplierContractDetails GetById(int id);
}