using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using MediatorPatternSample.Web.Models;
using MediatorPatternSample.Web.Contracts.Queries;
using MediatR;

namespace MediatorPatternSample.Web.Application
{
    public class QueryHandlers :
        IRequestHandler<GetCategories, IEnumerable<Category>>,
        IRequestHandler<GetProducts, IEnumerable<Product>>
    {
        private readonly UnitOfWork.IRepository _repository;
        public QueryHandlers(UnitOfWork.IRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<Category>> Handle(GetCategories request, CancellationToken cancellationToken)
        {
            var data = _repository.GetCategories();
            return Task.FromResult(data);
        }

        public Task<IEnumerable<Product>> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            var data = _repository.GetProducts(request.CategoryId);
            return Task.FromResult(data);
        }
    }
}
