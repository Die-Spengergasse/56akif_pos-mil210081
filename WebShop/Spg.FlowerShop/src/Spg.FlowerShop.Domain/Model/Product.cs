namespace Spg.FlowerShop.Domain.Model
{
    public class Product
    {
        public int Id { get; }

        public string ProductName { get; set; } = string.Empty;

        public decimal CurrentPrice { get; set; } 

        public string ProductDescription { get; set; } = string.Empty;

        public ProductCategory ProductCategory { get; set; } = default!;

        public string ProductImage { get; set; } = string.Empty;
                
        public List<Price> _prices = new();
        public IReadOnlyList<Price> Prices => _prices;
                
        public List<Review> _reviews = new();
        public IReadOnlyList<Review> Reviews => _reviews;
                
        public List<ShoppingCartItem> _shoppingCartItems = new();
        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems;

        public Product(int id, string productName, decimal currentPrice, string productDescription, ProductCategory productCategory, string productImage)
        {
            Id = id;
            ProductName = productName;
            CurrentPrice = currentPrice;
            ProductDescription = productDescription;
            ProductCategory = productCategory;
            ProductImage = productImage;
        }

        public Product()
        {
        }
    }
}
