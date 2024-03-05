using AutoMapper;
using Catalog.Application.Responses;
using Catalog.Core.Entities;

namespace Catalog.Application.Mappers
{
    public class ProductMappingProfile : Profile
    {
        public ProductMappingProfile()
        {
            //created mapping between ProductBrand Model and Brands response
            CreateMap<ProductBrand, BrandResponse>().ReverseMap();
        }
    }
}
