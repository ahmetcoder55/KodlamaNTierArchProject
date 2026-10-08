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
        Task Update(ProductUpdateDto entity);
        Task Remove(int id);
    }
}