using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class ProductService
    {
        public readonly Dictionary<int, ProductDetails> _products = new()
        {
            {1, new ProductDetails("Apple iPod", 200, 50)},
            {2, new ProductDetails("Surface Book", 2200, 10)},
            {3, new ProductDetails("XPS 15", 1600, 3)},
        };

        public ProductDetails GetProduct(int productId)
        {
            return _products.TryGetValue(productId,out var product) ? product : null;
        }

        public void UpdateProduct(int productId, string newName, decimal newSellPrice)
        {
            var product = GetProduct(productId);

            if (product is null)
                return;
            
            product.ProductName = newName;
            product.SellPrice = newSellPrice;
        }
    }

    public class ProductDetails
    {
        public string ProductName { get; set; }
        public decimal SellPrice { get; set; }
        public int QuantityInStock { get; set; }

        public ProductDetails(string productName, decimal sellPrice, int quantityInStock)
        {
            ProductName = productName;
            SellPrice = sellPrice;
            QuantityInStock = quantityInStock;
        }
    }
}
