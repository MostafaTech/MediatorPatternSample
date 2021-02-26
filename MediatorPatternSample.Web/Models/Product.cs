using System;
using System.Collections.Generic;

namespace MediatorPatternSample.Web.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}
