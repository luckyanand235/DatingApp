using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options) // instead of seprate constructor we added primary constructor
    {
        public DbSet<AppUser> Users { get; set; }

    }
}
