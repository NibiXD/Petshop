using Petshop.Domain.Entities;
using Petshop.Domain.Interfaces.Repositories;
using Petshop.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Infrastructure.Data.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(PetshopContext context) : base(context)
        {
        }
    }
}
