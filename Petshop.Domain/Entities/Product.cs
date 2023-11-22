using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public long ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
