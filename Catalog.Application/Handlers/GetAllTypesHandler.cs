﻿using Catalog.Application.Mappers;
using Catalog.Application.Queries;
using Catalog.Application.Responses;
using Catalog.Core.Repositories;
using MediatR;

namespace Catalog.Application.Handlers
{
    public class GetAllTypesHandler : IRequestHandler<GetAllTypesQuery, IList<TypesResponse>>
    {
        private readonly ITypeRepository _repository;
        public GetAllTypesHandler(ITypeRepository typeRepository)
        {
            _repository = typeRepository;
        }
        public async Task<IList<TypesResponse>> Handle(GetAllTypesQuery request, CancellationToken cancellationToken)
        {
            var typesList = await _repository.GetAllTypes();
            var typesResponse = ProductMapper.Mapper.Map<IList<TypesResponse>>(typesList);
            return typesResponse;
        }
    }
}
