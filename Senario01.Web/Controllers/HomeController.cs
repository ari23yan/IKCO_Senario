using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Refit;
using Senario01.Application.Services.Interfaces;
using Senario01.Application.Services.Interfaces.City;
using Senario01.Domain.Dtos;
using Senario01.Domain.Dtos.City;
using Senario01.Domain.Entities;
using Senario01.Domain.Enums;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Swagger;
using Senario01.Domain.Enums.Common;
using Microsoft.OpenApi.Extensions;
using Azure.Core;
using Senario01.Domain.Dtos.Customer;
using AutoMapper;

namespace IKCO_Senario01.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

    public class HomeController : ControllerBase
    {

        private readonly ICustomerService _customerService;
        private readonly ICityService _cityService;
        private readonly ISwaggerProvider SwaggerDocs;
        private readonly IMapper _mapper;


        public HomeController(ICustomerService customerService, IMapper mapper, ICityService cityService, ISwaggerProvider swaggerProvider)
        {
            _customerService = customerService;
            _cityService = cityService;
            SwaggerDocs = swaggerProvider;
            _mapper = mapper;

        }


        [HttpGet(Name = "GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            try
            {

                var customers = await _customerService.GetAll();
                var customersDto = _mapper.Map<List<Customer>, List<CustomerListDto>>(customers);
                if (customers != null)
                {
                    return Ok(customersDto);
                }
                return BadRequest("0 Customers");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet(Name = "GetCustomerByName{name}")]
        public async Task<IActionResult> GetCustomerByName(string name)
        {
            try
            {
                if (name != null && ModelState.IsValid)
                {
                    var customer = await _customerService.GetCustomerByName(name);
                    if (customer != null)
                    {
                        return Ok(customer);
                    }
                    return BadRequest("0 Customers");
                }
                return BadRequest(RequestResponse.NullInputs.GetDisplayName());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpGet(Name = "GetCities")]
        public async Task<IActionResult> GetCities()
        {
            try
            {
                var city = await _cityService.GetAll();
                if (city != null)
                {
                    return Ok(city);

                }
                return BadRequest("0 citeis");
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpPost(Name = "AddCity")]
        public async Task<IActionResult> AddCity(AddCityDto request)
        {
            try
            {
                if (request != null && ModelState.IsValid)
                {
                    var city = await _cityService.AddCity(request);
                    if (city == RequestResponse.Success)
                    {
                        return Ok(RequestResponse.Success.GetDisplayName());
                    }
                    return BadRequest(RequestResponse.Faild.GetDisplayName());
                }
                return BadRequest(RequestResponse.NullInputs.GetDisplayName());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [HttpPost(Name = "AddCustomer")]
        public async Task<IActionResult> AddCustomer(AddCustomerDto request)
        {
            try
            {
                if (request != null && ModelState.IsValid)
                {
                    var customer = await _customerService.AddCustomer(request);
                    if (customer == RequestResponse.Success)
                    {
                        return Ok(RequestResponse.Success.GetDisplayName());
                    }
                    return BadRequest(RequestResponse.Faild.GetDisplayName());
                }
                return BadRequest(RequestResponse.NullInputs.GetDisplayName());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> EditCustomer([FromRoute] Guid id, EditCustomerDto request)
        {
            try
            {
                if (request != null && ModelState.IsValid)
                {
                    var customer = await _customerService.EditCustomer(id, request);
                    if (customer == RequestResponse.Success)
                    {
                        return Ok(RequestResponse.Success.GetDisplayName());
                    }
                    return BadRequest(RequestResponse.Faild.GetDisplayName());
                }
                return BadRequest(RequestResponse.NullInputs.GetDisplayName());
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var customer = await _customerService.DeleteCustomer(id);
                    if (customer == RequestResponse.Success)
                    {
                        return Ok(RequestResponse.Success.GetDisplayName());
                    }
                    return BadRequest(RequestResponse.Faild.GetDisplayName());
                }
                return BadRequest(RequestResponse.NullInputs.GetDisplayName());
            }
            catch (Exception)
            {

                throw;
            }
        }





    }
}
