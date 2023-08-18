using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Domain.Interfaces.City
{
    public interface ICityRepository : IRepository<Senario01.Domain.Entities.City>
    {
        Task<List<Senario01.Domain.Entities.City>> GetAllCitiesAsync();
    }
}
