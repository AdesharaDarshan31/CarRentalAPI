using Microsoft.EntityFrameworkCore;
using CarRentalAPI.Models;

namespace CarRentalAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}
