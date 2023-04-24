using Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
	public class SupplierContract:BaseEntity
	{
		public int SupplierId { get; set; }
		public DateTime ContractSignDate { get; set; }
		public DateTime ContractEndDate { get; set; }
		public DateTime PaymentDate { get; set; }

		public Supplier Supplier { get; set; }
	}
}
