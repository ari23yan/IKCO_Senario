using Senario01.Domain.Dtos.City;
using Senario01.Domain.Entities;
using Senario01.Domain.Enums.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Application.Services.Interfaces.City
{
    public interface ICityService
    {
        Task<List<Senario01.Domain.Entities.City>> GetAll();
        Task<RequestResponse> AddCity(AddCityDto request);
    }
}
