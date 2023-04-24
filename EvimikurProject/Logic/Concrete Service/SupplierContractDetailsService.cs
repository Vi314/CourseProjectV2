using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entity;
using Logic.Abstract_Service;
using Logic.Repository;

namespace Logic.Concrete_Service
{
	public class SupplierContractDetailsService:ISupplierContractDetailsService
	{
		private readonly IRepository<SupplierContractDetails> _repository;

		public SupplierContractDetailsService(IRepository<SupplierContractDetails> repository)
		{
			_repository = repository;
		}
		public string CreateSupplierContractDetails(SupplierContractDetails supplierContractDetails)
		{
			try
			{
				var result = _repository.Create(supplierContractDetails);
				return result;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return e.Message;
			}
		}

		public string UpdateSupplierContractDetails(SupplierContractDetails supplierContractDetails)
		{
			try
			{
				var result = _repository.Update(supplierContractDetails);
				return result;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return e.Message;
			}
		}

		public string DeleteSupplierContractDetails(int id)
		{
			try
			{
				var result = _repository.Delete(id);
				return result;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return e.Message;
			}
		}

		public IEnumerable<SupplierContractDetails> GetSupplierContractDetails()
		{
			try
			{
				return _repository.GetAll();
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}

		public SupplierContractDetails GetById(int id)
		{
			try
			{
				return _repository.GetById(id);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	}
}
