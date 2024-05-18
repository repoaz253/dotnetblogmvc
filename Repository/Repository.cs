using dotnetblog.Repository.IRepository;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using dotnetblog.Data;
using Microsoft.EntityFrameworkCore;

namespace dotnetblog.Repository
    
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        internal DbSet<T> dbSet;
        public Repository(AppDbContext context)
        {
            _context = context; 
            this.dbSet=_context.Set<T>();
            //_dbCategories == dbSet
            
        }
        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query =query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();  
        }

        public void Remove(T entity)
        {
           dbSet.Remove(entity);
        }
    }
}
