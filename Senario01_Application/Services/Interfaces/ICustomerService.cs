using Senario01.Domain.Dtos.City;
using Senario01.Domain.Dtos.Customer;
using Senario01.Domain.Entities;
using Senario01.Domain.Enums.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Application.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetAll();
        Task<RequestResponse> AddCustomer(AddCustomerDto request);
        Task<Customer> GetCustomerByName(string name);
        Task<RequestResponse> EditCustomer(Guid id,EditCustomerDto request);
        Task<RequestResponse> DeleteCustomer(Guid id);

    }
}
