using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetProductByBrandQueryHandler : IRequestHandler<GetProductByBrandQuery, IList<ProductResponse>>
    {
        private readonly IProductRepository _repository;
        public GetProductByBrandQueryHandler(IProductRepository productRepository)
        {
            _repository = productRepository;
        }
        public async Task<IList<ProductResponse>> Handle(GetProductByBrandQuery request, CancellationToken cancellationToken)
        {
            var productList = await _repository.GetProductByBrand(request.BrandName);
            var productListResponse = ProductMapper.Mapper.Map<IList<ProductResponse>>(productList);
            return productListResponse;
        }
    }
}
