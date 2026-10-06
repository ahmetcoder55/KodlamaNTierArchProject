using KodlamaNTierProject.DataAccess.Abstract;
using KodlamaNTierProject.DataAccess.Concrete.Data.Context;
using KodlamaNTierProject.Entities.Concrete;

namespace KodlamaNTierProject.DataAccess.Concrete
{
    public class ProductRepository : GenericRepository<Product, AppDbContext>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}