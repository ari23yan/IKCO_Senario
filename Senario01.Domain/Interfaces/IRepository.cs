using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T?> GetAsync(int id);
        Task<T?> SingleOrDefaultAsync(Expression<Func<T, bool>> filter);
    
        Task<List<T>> GetAllAsync();

        Task<List<T?>> GetAllAsync(Expression<Func<T, bool>> filter);

        Task AddAsync(T entity);

        void Remove(T entity);

        void Update(T item);

        Task SaveAsync();
    }
}
