using KodlamaNTierProject.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KodlamaNTierProject.DataAccess.Concrete.Data.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}