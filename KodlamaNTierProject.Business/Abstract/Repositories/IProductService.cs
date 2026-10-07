using KodlamaNTierProject.Business.Concrete;
using KodlamaNTierProject.Business.Concrete.DTOs;
using KodlamaNTierProject.Entities.Concrete;

namespace KodlamaNTierProject.Business.Abstract.Repositories
{
    public interface IProductService
    {
         Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto> GetByIdAsync(int id);
        Task AddAsync(ProductCreateDto entity);
        void Update(ProductUpdateDto entity);
        void Remove(int id);
    }
}