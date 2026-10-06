using KodlamaNTierProject.DataAccess.Abstract;
using KodlamaNTierProject.DataAccess.Abstract.UnitOfWorks;
using KodlamaNTierProject.DataAccess.Concrete.Data.Context;

namespace KodlamaNTierProject.DataAccess.Concrete.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        private readonly IProductRepository _productRepository;

        private readonly ICategoryRepository _categoryRepository;

        public UnitOfWork(AppDbContext context, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
        }

        public IProductRepository Product => _productRepository;

        public ICategoryRepository Category => _categoryRepository;

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}