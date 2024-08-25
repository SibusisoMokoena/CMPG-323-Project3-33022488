using TelemetryPortal_MVC.Models;

namespace TelemetryPortal_MVC.Repository
{
    public interface IClientsRepository 
    {
    Task<Client> GetClientByIdAsync(Guid clientId);
        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task AddClientAsync(Client client);
        Task UpdateClientAsync(Client client);
        Task DeleteClientAsync(int clientId);
    }
}
