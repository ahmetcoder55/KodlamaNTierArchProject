using KodlamaNTierProject.Business.Abstract.Repositories;
using KodlamaNTierProject.Business.Abstract.UnitOfWorks;
using KodlamaNTierProject.Business.Concrete.Mappings;
using KodlamaNTierProject.Business.Concrete.Services;
using KodlamaNTierProject.Business.Concrete.UnitOfWorks;
using Microsoft.Extensions.DependencyInjection;

namespace KodlamaNTierProject.Business.Concrete.Extensions
{
    public static class BusinessExtensions
    {
        public static void ConfigureBusiness(this IServiceCollection services)
        {
            services.AddAutoMapper(x=>x.AddMaps(typeof(GeneralMapping)));

            services.AddScoped<IProductService,ProductManager>();
            services.AddScoped<IServiceManager,ServiceManager>();
        }
    }
}