using Microsoft.EntityFrameworkCore;
using TelemetryPortal_MVC.Data;
using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public class ClientsRepository : GenericRepository<Client>, IClientsRepository
    {
        private readonly TechtrendsContext _context;

        public ClientsRepository(TechtrendsContext context) : base(context)
        {
            _context = context;
        }

        // Implementing the GetClientByIdAsync(Guid clientId) method
        public async Task<Client> GetClientByIdAsync(Guid clientId)
        {
            return await _context.Clients.FindAsync(clientId);
        }
    }
}