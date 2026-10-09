using KodlamaNTierProject.Business.Abstract.Repositories;

namespace KodlamaNTierProject.Business.Abstract.UnitOfWorks
{
    public interface IServiceManager
    {
       public IProductService ProductService {get;}
    }
}