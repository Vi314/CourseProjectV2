using Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
    public class Order:BaseEntity
    {
        public int ProductId { get; set; }
        public int DealerId { get; set; }
        public decimal Price { get; set; }

        public Product Product { get; set; }
        public Dealer Dealer { get; set; }
    }
}
