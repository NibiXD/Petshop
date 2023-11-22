using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Domain.Entities
{
    public class Address : BaseEntity
    {
        public long UserId { get; set; }
        public string CEP { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public User User { get; set; }
    }
}
