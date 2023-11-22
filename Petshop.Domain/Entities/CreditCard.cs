using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Domain.Entities
{
    public class CreditCard : BaseEntity
    {
        public long UserId { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime ExpireDate { get; set; }
        public int CVV { get; set; }
    }
}
