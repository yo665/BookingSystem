using System.Threading.Tasks;
using BookingSystem.Data;
using BookingSystem.Models;
using BookingSystem.Services;
using Microsoft.EntityFrameworkCore;

public class ClientDetailsService : IClientDetailsService
{
    private readonly BookingSystemDbContext _context;

    public ClientDetailsService(BookingSystemDbContext context)
    {
        _context = context;
    }

    public async Task SaveClientDetailsAsync(Client_Details clientDetails)
    {
        _context.ClientDetails.Add(clientDetails);
        await _context.SaveChangesAsync();
    }
}
