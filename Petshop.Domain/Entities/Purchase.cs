using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Domain.Entities
{
    public class Purchase : BaseEntity
    {
        public long PaymentMethod { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public DateTime PurchaseDate { get; set; }
        public double TotalValue { get; set; }
    }
}
