using System;
using Shop.Aplication.ViewModels;

namespace Shop.Aplication.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProducts();
    }
}
