namespace Spg.FlowerShop.Domain.Model
{
    public class ShoppingCartItem
    {
        public int Id { get; }

        public int ItemCount { get; set; }

        public Product Product { get; set; } = default!;

        public ShoppingCart ShoppingCart { get; set; } = default!;

        public ShoppingCartItem(int id, int itemCount, Product product, ShoppingCart shoppingCart)
        {
            Id = id;
            ItemCount = itemCount;
            Product = product;
            ShoppingCart = shoppingCart;
        }
        public ShoppingCartItem()
        {
        }
    }
}
