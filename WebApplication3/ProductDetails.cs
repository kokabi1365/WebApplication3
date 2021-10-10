namespace WebApplication3
{
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