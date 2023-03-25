using ASP.NET_Training.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Training.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
