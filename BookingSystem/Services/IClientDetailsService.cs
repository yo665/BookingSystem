using BookingSystem.Models;

namespace BookingSystem.Services
{
    public interface IClientDetailsService
    {
        Task SaveClientDetailsAsync(Client_Details clientDetails);
    }
}
