using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TelemetryPortal_MVC.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<bool> ExistsAsync(Guid? id)
        Task<T> GetByIdAsync(Guid? id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);

        // custome code that were not provided:

        void save();
        void create(T t);
        bool Edit(Guid id, T t);
        T checkDetails(Guid? id);
        bool CheckId(Guid? id);
    }
}
