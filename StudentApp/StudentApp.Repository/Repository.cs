using Microsoft.EntityFrameworkCore;
using StudentApp.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        DbSet<T> _entities;
        string _errorMessage = string.Empty;
        IDataContext _context;
        public Repository(IDataContext context)
        {
            _context = context;
        }
        protected virtual DbSet<T> Entities
        {
            get { return _entities ?? (_entities = _context.Set<T>()); }
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Entities.ToListAsync();
        }
        public async Task<T> GetAsync(int id)
        {
            return await Entities.FindAsync(id);
        }
        public async Task<T> CreateAsync(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            await Entities.AddAsync(entity);
            return entity;
        }
        public virtual T Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        public virtual T Delete(int id)
        {
            T entity = Entities.SingleOrDefault(s => s.Id == id);
            Entities.Remove(entity);
            return entity;
        }
    }
}
