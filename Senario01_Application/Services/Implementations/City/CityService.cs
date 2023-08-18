using AutoMapper;
using Senario01.Application.Services.Interfaces.City;
using Senario01.Domain.Dtos.City;
using Senario01.Domain.Entities;
using Senario01.Domain.Enums.Common;
using Senario01.Domain.Interfaces.City;
using Senario01.Domain.Interfaces.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Application.Services.Implementations.City
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;
        private readonly IMapper _mapper;
        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            _cityRepository = cityRepository;
            _mapper = mapper;

        }

        public async Task<RequestResponse> AddCity(AddCityDto request)
        {

            if (request == null) return RequestResponse.Faild;
            else
            {
                Domain.Entities.City city = new Domain.Entities.City()
                {
                    CityName = request.CityName,
                    Status = Domain.Enums.StatusType.Active
                };
                await _cityRepository.AddAsync(city);
                await _cityRepository.SaveAsync();
                return RequestResponse.Success;
            }

        }

        public async Task<List<Domain.Entities.City>> GetAll()
        {
            return await _cityRepository.GetAllCitiesAsync();
        }
    }
}
