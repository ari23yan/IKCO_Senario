using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Senario01.Application.Services.Implementations;
using Senario01.Application.Services.Implementations.City;
using Senario01.Application.Services.Interfaces;
using Senario01.Application.Services.Interfaces.City;
using Senario01.Application.Utilities.FluentValidation;
using Senario01.Data.Context;
using Senario01.Data.Repositories;
using Senario01.Data.Repositories.City;
using Senario01.Data.Repositories.Customer;
using Senario01.Domain.Dtos;
using Senario01.Domain.Dtos.City;
using Senario01.Domain.Dtos.Customer;
using Senario01.Domain.Interfaces;
using Senario01.Domain.Interfaces.City;
using Senario01.Domain.Interfaces.Customer;
using Senario01.Domain.Utilities.Fluent;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Ioc
{
    public static class DependencyContainer
    {
        public static void AddDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICityRepository, CityRepository>();
            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IValidator<AddCustomerDto>, CustomerValidator>();
            services.AddScoped<IValidator<AddCityDto>, CityValidatior>();

        }
    }
}
