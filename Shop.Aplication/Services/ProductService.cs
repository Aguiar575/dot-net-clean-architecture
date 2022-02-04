using System;
using Shop.Aplication.Interfaces;
using Shop.Aplication.ViewModels;
using Shop.Domain.Interfaces;

namespace Shop.Aplication.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductViewModel GetProducts()
        {
            return new ProductViewModel
            {
                Products = _productRepository.GetProducts()
            };
        }
    }
}
