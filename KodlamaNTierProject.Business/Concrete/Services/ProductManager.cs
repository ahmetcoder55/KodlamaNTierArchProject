using AutoMapper;
using KodlamaNTierProject.Business.Abstract.Repositories;
using KodlamaNTierProject.Business.Concrete.DTOs;
using KodlamaNTierProject.DataAccess.Abstract.UnitOfWorks;
using KodlamaNTierProject.Entities.Concrete;

namespace KodlamaNTierProject.Business.Concrete.Services
{
    public class ProductManager : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _manager;

        public ProductManager(IMapper mapper, IUnitOfWork manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        public async Task AddAsync(ProductCreateDto entity)
        {
            var product=_mapper.Map<Product>(entity);
            if(entity is not null)
            {
                await _manager.Product.AddAsync(product);
                await _manager.SaveAsync();
            }
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
           return _mapper.Map<IEnumerable<ProductDto>>(await _manager.Product.GetAllAsync()); 
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
          return _mapper.Map<ProductDto>(await _manager.Product.GetByIdAsync(id)); 

        }

        public async Task Remove(int id)
        {

            var product=await _manager.Product.GetByIdAsync(id);
            if(product is null)
            {
                throw new NullReferenceException();
            }
            _manager.Product.Remove(product);
            await _manager.SaveAsync();
        }

        public async Task Update(ProductUpdateDto entity)
        {
            var product=_mapper.Map<Product>(entity);
            if (product == null)
            {
                throw new Exception("The Product is not found!");
            }
            _manager.Product.Update(product);
            await _manager.SaveAsync();
        }

        
    }
}