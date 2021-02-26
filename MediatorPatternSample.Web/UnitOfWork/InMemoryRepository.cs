using MediatorPatternSample.Web.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace MediatorPatternSample.Web.UnitOfWork
{
    public class InMemoryRepository : IRepository
    {
        private readonly List<Category> _categories;
        private readonly List<Product> _products;
        public InMemoryRepository()
        {
            _categories = new List<Category>();
            _categories.Add(new Category { Id = Guid.NewGuid(), Name = "Mobiles" });
            _categories.Add(new Category { Id = Guid.NewGuid(), Name = "Laptops" });

            _products = new List<Product>();
            _products.Add(new Product { Id = Guid.NewGuid(), Name = "IPhone 12", Quantity = 10, CategoryId = _categories[0].Id });
            _products.Add(new Product { Id = Guid.NewGuid(), Name = "IPhone X", Quantity = 4, CategoryId = _categories[0].Id });
            _products.Add(new Product { Id = Guid.NewGuid(), Name = "Lenovo Ideapad 1520", Quantity = 3, CategoryId = _categories[1].Id });
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories.ToArray();
        }

        public IEnumerable<Product> GetProducts(Guid? categoryId)
        {
            var q = _products.AsQueryable();
            if (categoryId.HasValue)
                q = q.Where(x => x.CategoryId == categoryId);
            return q.ToArray();
        }
    }
}
