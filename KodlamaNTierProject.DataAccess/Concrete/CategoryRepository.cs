using KodlamaNTierProject.DataAccess.Abstract;
using KodlamaNTierProject.DataAccess.Concrete.Data.Context;
using KodlamaNTierProject.Entities.Concrete;

namespace KodlamaNTierProject.DataAccess.Concrete
{
    public class CategoryRepository : GenericRepository<Category, AppDbContext>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
    }
}