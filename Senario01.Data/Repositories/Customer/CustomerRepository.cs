using Microsoft.EntityFrameworkCore;
using Senario01.Data.Context;
using Senario01.Domain.Entities;
using Senario01.Domain.Interfaces;
using Senario01.Domain.Interfaces.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Data.Repositories.Customer
{
    public class CustomerRepository : Repository<Senario01.Domain.Entities.Customer>, ICustomerRepository
    {

        public CustomerRepository(Senario01DbContext context) : base(context) { }

        public async Task<List<Domain.Entities.Customer>> GetAllCustomersAsync()
        {
            return await Context.Customers.ToListAsync();
        }

        public async Task<Domain.Entities.Customer> GetCustomersByIdAsync(Guid id)
        {
            return await Context.Customers.FirstOrDefaultAsync(x=>x.Id == id);

        }

        public async Task<Domain.Entities.Customer> GetCustomersByNameAsync(string name)
        {
            return await Context.Customers.FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}
