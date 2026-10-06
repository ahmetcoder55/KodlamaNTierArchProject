using KodlamaNTierProject.DataAccess.Abstract;
using KodlamaNTierProject.DataAccess.Abstract.UnitOfWorks;
using KodlamaNTierProject.DataAccess.Concrete.Data.Context;
using KodlamaNTierProject.DataAccess.Concrete.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace KodlamaNTierProject.DataAccess.Concrete.Extensions
{
    public static class DataAccessExtensions
    {
        public static void ConfigureDatabase(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(x =>
            {
                x.UseSqlite("Data Source=ntierarch.db");
            });
        }
        public static void ConfigureDataAccess(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository,ProductRepository>();
            services.AddScoped<ICategoryRepository,CategoryRepository>();
            services.AddScoped<IUnitOfWork,UnitOfWork>();

        }
    }
}