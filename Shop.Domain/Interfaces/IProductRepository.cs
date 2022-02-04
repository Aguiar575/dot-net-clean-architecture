using System.Collections.Generic;
using Shop.Domain.Entities;

namespace Shop.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
