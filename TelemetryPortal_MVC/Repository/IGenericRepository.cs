using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TelemetryPortal_MVC.Repository
{
    public interface IGenericRepository<T> where T : class
    {
      async Task<T> GetByIdAsync(int id);
        
    }
}
