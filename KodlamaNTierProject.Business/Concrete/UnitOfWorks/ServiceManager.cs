using KodlamaNTierProject.Business.Abstract.Repositories;
using KodlamaNTierProject.Business.Abstract.UnitOfWorks;

namespace KodlamaNTierProject.Business.Concrete.UnitOfWorks
{
    public class ServiceManager : IServiceManager
    {
        private readonly IProductService _productService;

        public ServiceManager(IProductService productService)
        {
            _productService = productService;
        }

        public IProductService ProductService => _productService;
    }
}