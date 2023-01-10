namespace Spg.FlowerShop.Domain.Model
{
    public class Product
    {
        public string ProductName { get; private set; } = string.Empty;  // pk

        public decimal CurrentPrice { get; } // aber redundant in db

        public string ProductDescription { get; set; } = string.Empty;

        public string ProductCategoryNavigationId { get; set; } = string.Empty;
        public ProductCategory ProductCategoryNavigation { get; set; } = default!; // vk

        public string ProductImage { get; set; } = string.Empty;

        private List<Price> _prices = new();
        public IReadOnlyList<Price> Prices => _prices;

        private List<Review> _reviews = new();
        public IReadOnlyList<Review> Reviews => _reviews;
                
        private List<ShoppingCartItem> _shoppingCartItems = new();
        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems;

        public Product(string productName, string productDescription, string productImage)
        {
            ProductName = productName;
            //CurrentPrice = currentPrice;
            ProductDescription = productDescription;
            ProductImage = productImage;
        }
        protected Product()
        { }
    }
}
