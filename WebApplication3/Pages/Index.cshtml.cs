using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProductService _productService;

        public IndexModel(ProductService productService)
        {
            _productService = productService;
        }

        public Dictionary<int,ProductDetails> Products { get; private set; }

        public void OnGet()
        {
            Products = _productService.Products;
        }
    }
}
