using System;
using System.Collections.Generic;

namespace MediatorPatternSample.Web.Contracts.Queries
{
    public class GetProducts : MediatR.IRequest<IEnumerable<Models.Product>>
    {
        public Guid? CategoryId { get; set; }
    }
}
