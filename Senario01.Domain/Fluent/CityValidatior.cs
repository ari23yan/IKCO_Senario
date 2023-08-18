using FluentValidation;
using Senario01.Domain.Dtos.City;
using Senario01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Domain.Utilities.Fluent
{
    public class CityValidatior: AbstractValidator<AddCityDto>
    {
        public CityValidatior()
        {
            RuleFor(x => x.CityName).NotEmpty().WithMessage("Please specify a CityName name");
        }
    }
}
