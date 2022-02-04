using Microsoft.AspNetCore.Mvc;
using Shop.Aplication.Interfaces;
using Shop.Aplication.ViewModels;

namespace Shop.Web.Mvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            ProductViewModel model = _productService.GetProducts();
            return View(model);
        }
    }
}
