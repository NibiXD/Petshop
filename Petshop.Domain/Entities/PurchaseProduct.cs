using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Domain.Entities
{
    public class PurchaseProduct
    {
        public long PurchaseId { get; set; }
        public Purchase Purchase { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
