using Senario01.Application.Services.Interfaces;
using Senario01.Domain.Dtos.City;
using Senario01.Domain.Entities;
using Senario01.Domain.Enums.Common;
using Senario01.Domain.Interfaces.Customer;
using Senario01.Domain.Entities;
using Senario01.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Senario01.Domain.Dtos.Customer;
using Azure.Core;

namespace Senario01.Application.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<RequestResponse> AddCustomer(AddCustomerDto request)
        {
            if (request == null) return RequestResponse.NullInputs;
            else
            {
                Customer city = new Customer()
                {
                    BirthDate = request.BirthDate,
                    CityId = request.CityId,
                    FatherName = request.FatherName,
                    LastName = request.LastName,
                    Name = request.Name,
                    Status = StatusType.Active
                };
                await _customerRepository.AddAsync(city);
                await _customerRepository.SaveAsync();
                return RequestResponse.Success;
            }
        }

        public async Task<RequestResponse> DeleteCustomer(Guid id)
        {
            if (id == null) return RequestResponse.NullInputs;
            else
            {
                var customer = await _customerRepository.GetCustomersByIdAsync(id);
                if (customer != null)
                {
                    _customerRepository.Remove(customer);
                    await _customerRepository.SaveAsync();
                    return RequestResponse.Success;
                }
                return RequestResponse.NullResult;
            }
        }

        public async Task<RequestResponse> EditCustomer(Guid id, EditCustomerDto request)
        {
            if (id == null) return RequestResponse.NullInputs;
            else
            {
                var customer = await _customerRepository.GetCustomersByIdAsync(id);
                if (customer != null)
                {
                   customer.BirthDate = request.BirthDate ?? customer.BirthDate;
                   customer.Name = request.Name ?? customer.Name;
                   customer.FatherName = request.FatherName ?? customer.FatherName;
                   customer.LastName = request.LastName ?? customer.LastName;
                   customer.LastName = request.LastName ?? customer.LastName;
                    _customerRepository.Update(customer);
                   await _customerRepository.SaveAsync();
                    return RequestResponse.Success;
                }
                return RequestResponse.NullResult;
            }
        }

        public async Task<List<Customer>> GetAll()
        {
            return await _customerRepository.GetAllCustomersAsync();
        }

        public async Task<Customer> GetCustomerByName(string name)
        {
            return await _customerRepository.GetCustomersByNameAsync(name);
        }
    }
}
