using System;
using System.Collections.Generic;

namespace MediatorPatternSample.Web.Contracts.Queries
{
    public class GetCategories : MediatR.IRequest<IEnumerable<Models.Category>>
    {
    }
}
