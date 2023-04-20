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
        public byte LooksGrade { get; set; }
        public byte UsabilityGrade { get; set; }
        public byte FunctionalityGrade { get; set; }
        public byte InnovativeGrade { get; set; }
        public byte PriceAdvantageGrade { get; set; }
        public byte PotentialSalesGrade { get; set; }
        
		public Category Category { get; set; }
    }
}
