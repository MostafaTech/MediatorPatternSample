using System;
using System.Collections.Generic;

namespace MediatorPatternSample.Web.UnitOfWork
{
    public interface IRepository
    {
        IEnumerable<Models.Category> GetCategories();
        IEnumerable<Models.Product> GetProducts(Guid? categoryId);
    }
}
