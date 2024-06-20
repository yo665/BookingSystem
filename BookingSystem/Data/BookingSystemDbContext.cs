using Microsoft.EntityFrameworkCore;
using BookingSystem.Models;

namespace BookingSystem.Data
{
    public class BookingSystemDbContext : DbContext
    {
        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client_Details> ClientDetails { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
    }
}