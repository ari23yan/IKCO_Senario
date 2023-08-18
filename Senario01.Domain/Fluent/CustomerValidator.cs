using FluentValidation;
using Senario01.Domain.Dtos.Customer;
using Senario01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Application.Utilities.FluentValidation
{
    public class CustomerValidator: AbstractValidator<AddCustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Please specify a first name");
            RuleFor(x => x.FatherName).NotEmpty().WithMessage("Please specify a Father name");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Please specify a Father name");
            RuleFor(x => x.BirthDate).NotEmpty().WithMessage("Please specify a BirthDate");
        }

    }
}
