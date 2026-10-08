using AutoMapper;
using KodlamaNTierProject.Business.Concrete.DTOs;
using KodlamaNTierProject.Entities.Concrete;

namespace KodlamaNTierProject.Business.Concrete.Mappings
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
            CreateMap<Product,ProductCreateDto>().ReverseMap();
            CreateMap<Product,ProductUpdateDto>().ReverseMap();

        }
    }
}