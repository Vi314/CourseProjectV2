using Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
	public class SupplierContractDetails:BaseEntity
	{
		public int ProductId { get; set; }
		public int SupplierId { get; set;}
		public decimal Price { get; set; }
		public decimal ShippingCost { get; set; }
		public float Tax { get; set; }
	}
}
