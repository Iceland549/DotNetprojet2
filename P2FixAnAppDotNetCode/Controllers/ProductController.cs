using Microsoft.AspNetCore.Mvc;
using P2FixAnAppDotNetCode.Models;
using P2FixAnAppDotNetCode.Models.Services;
using System.Collections.Generic;

namespace P2FixAnAppDotNetCode.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;

        public ProductController(IProductService productService, ILanguageService languageService)
        {
            _productService = productService;
            _languageService = languageService;

        }

        public IActionResult Index()
        {
            //var culture = _languageService.SetCulture(string.Empty);

            //HttpContext.Items.Clear();

            //_languageService.UpdateCultureCookie(HttpContext, culture);

            List<Product> products = _productService.GetAllProducts();
            return View(products);
        }
    }
}