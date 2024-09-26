using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace TelemetryPortal_MVC.Repository
{
    public interface IGenericRepository
    {
        project GetProjectByIdAsync();
    }
}
