using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swd.PlayCollector.Repository
{


    public class GenericRepository<TEntity, TModel> : IGenericRepository<TEntity>
        where TEntity : class, new()
        where TModel : DbContext, new()
    {

        //Member
        private DbContext _dbContext;
        private DbSet<TEntity> _dbSet;


        //Properties
        public DbSet<TEntity> DbSet
        {
            get { return _dbSet; }  
        }


        //Constructor
        public GenericRepository()
        {
            Init(new TModel());
        }


        public GenericRepository(DbContext context)
        {
            Init(context);
        }


        private void Init(DbContext contex)
        {
            _dbContext = contex;
            _dbSet = contex.Set<TEntity>();
        }








        public void Add(TEntity t)
        {
            _dbSet.Add(t);
            _dbContext.SaveChanges();
        }

        public async Task AddAsync(TEntity t)
        {
            await _dbSet.AddAsync(t);
            await _dbContext.SaveChangesAsync();
        }




        public void Delete(object key)
        {
            TEntity existing = _dbSet.Find(key);
            if(existing != null)
            {
                _dbSet.Remove(existing);
                _dbContext.SaveChanges();
            }
            
        }

        public Task DeleteAsync(object key)
        {
            throw new NotImplementedException();
        }



        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public Task<IQueryable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }


        public TEntity GetById(object key)
        {
            return _dbSet.Find(key);
        }

        public Task<TEntity> GetByIdAsync(object key)
        {
            throw new NotImplementedException();
        }



        public void Update(TEntity t, object key)
        {
            TEntity existing = _dbSet.Find(key);
            if(existing != null)
            {
                _dbContext.Entry(existing).CurrentValues.SetValues(t);
                _dbContext.SaveChanges();
                _dbContext.Entry(existing).Reload();
            }

        }

        public Task UpdateAsync(TEntity t, object key)
        {
            throw new NotImplementedException();
        }
    }


}
