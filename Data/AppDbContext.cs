using Microsoft.EntityFrameworkCore;
using monitorapplication.Models;

namespace monitorapplication.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options) 
        {
            
        }
    }
}
