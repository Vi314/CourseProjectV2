using Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
