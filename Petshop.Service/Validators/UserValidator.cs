using FluentValidation;
using Petshop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop.Service.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Name)
                .NotEmpty().WithMessage("Property Name can't be empty")
                .NotNull().WithMessage("Property Name can't be null");
            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Property Email can't be empty")
                .NotNull().WithMessage("Property Email can't be null");
            RuleFor(u => u.Password)
                .NotEmpty().WithMessage("Property Password can't be empty")
                .NotNull().WithMessage("Property Password can't be null");
        }
    }
}
