using Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
    public class DealerStocks:BaseEntity
    {
        public int? DealerId { get; set; }
        public int? ProductId { get; set; }
        public int? Amount { get; set; }

        public Dealer? Dealer { get; set; }
        public Product? Product { get; set; }

    }
}
