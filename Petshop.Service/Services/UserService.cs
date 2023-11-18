using FluentValidation;
using Petshop.Domain.Entities;
using Petshop.Domain.Interfaces.Repositories;
using Petshop.Domain.Interfaces.Services;

namespace Petshop.Service.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IBaseRepository<User> repository, IValidator<User> validator) : base(repository, validator)
        {
        }
    }
}
