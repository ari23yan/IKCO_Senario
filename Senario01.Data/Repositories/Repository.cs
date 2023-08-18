using Microsoft.EntityFrameworkCore;
using Senario01.Data.Context;
using Senario01.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Senario01.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly Senario01DbContext Context;
        protected DbSet<T> entities;

        public Repository(Senario01DbContext context)
        {
            Context = context;
            entities = Context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await entities.AddAsync(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await entities.ToListAsync();
        }

        public async Task<List<T?>> GetAllAsync(Expression<Func<T, bool>> filter)
        {
            return await entities.Where(filter).ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await entities.FindAsync(id);
        }

        public async Task<T?> SingleOrDefaultAsync(Expression<Func<T, bool>> filter)
        {
            return await entities.SingleOrDefaultAsync(filter);
        }

        public void Remove(T entity)
        {
            entities.Remove(entity);
        }

        public virtual void Update(T entity)
        {
            entities.Update(entity);
        }

        public async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
