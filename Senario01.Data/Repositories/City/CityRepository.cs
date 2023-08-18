using Microsoft.EntityFrameworkCore;
using Senario01.Data.Context;
using Senario01.Domain.Interfaces.City;
using Senario01.Domain.Interfaces.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Data.Repositories.City
{
    public class CityRepository: Repository<Senario01.Domain.Entities.City>, ICityRepository
    {
        public CityRepository(Senario01DbContext context) : base(context)
        {
        }

        public  Task<List<Domain.Entities.City>> GetAllCitiesAsync()
        {
          return  Context.Cities.ToListAsync();
        }
    }
}
