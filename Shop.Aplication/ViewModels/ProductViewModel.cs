using System;
using System.Collections.Generic;
using Shop.Domain.Entities;

namespace Shop.Aplication.ViewModels
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products {get; set;}
    }
}
