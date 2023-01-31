using Microsoft.EntityFrameworkCore;

namespace Swd.PlayCollector.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {


        DbSet<TEntity> DbSet { get; }

        //Create
        void Add(TEntity t);
        Task AddAsync(TEntity t);

        //Read
        IQueryable<TEntity> GetAll();
        Task<IQueryable<TEntity>> GetAllAsync();

        //ReadById
        TEntity GetById(object key);
        Task<TEntity> GetByIdAsync(object key);

        //Update
        void Update(TEntity t, object key);
        Task UpdateAsync(TEntity t, object key);

        //Delete
        void Delete(object key);
        Task DeleteAsync(object key);



    }
}