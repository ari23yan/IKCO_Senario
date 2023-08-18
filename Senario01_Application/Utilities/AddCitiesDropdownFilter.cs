using System.Collections.Generic;
using System.Numerics;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Senario01.Application.Services.Interfaces.City;
using Senario01.Data.Context;
using Senario01.Domain.Entities;
using Swashbuckle.AspNetCore.SwaggerGen;

public class AddCitiesDropdownFilter : IParameterFilter
{
    readonly IServiceScopeFactory _serviceScopeFactory;

    public AddCitiesDropdownFilter(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }
    public async void Apply(OpenApiParameter parameter, ParameterFilterContext context)
    {
        if (parameter.Name.Equals("planet", StringComparison.InvariantCultureIgnoreCase))
        {

            using (var scope =  _serviceScopeFactory.CreateScope())
            {
                var planetsContext = scope.ServiceProvider.GetRequiredService<ICityService>();
                List<City> planets = await planetsContext.GetAll();

                parameter.Schema.Enum = planets.Select(p => new OpenApiString(p.CityName)).ToList<IOpenApiAny>();

            }
        }
    }
}
