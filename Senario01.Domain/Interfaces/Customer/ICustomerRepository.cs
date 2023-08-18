using Senario01.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Senario01.Domain.Interfaces.Customer
{
    public interface ICustomerRepository:IRepository<Senario01.Domain.Entities.Customer>
    {
       Task<List<Senario01.Domain.Entities.Customer>> GetAllCustomersAsync();
       Task<Senario01.Domain.Entities.Customer> GetCustomersByNameAsync(string name);
       Task<Senario01.Domain.Entities.Customer> GetCustomersByIdAsync(Guid id);
    }
}
