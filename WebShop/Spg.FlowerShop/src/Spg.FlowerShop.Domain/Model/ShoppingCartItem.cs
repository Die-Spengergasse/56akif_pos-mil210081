namespace Spg.FlowerShop.Domain.Model
{
    public class ShoppingCartItem
    {
        public int Id { get; }
        public int ItemCount { get; set; }

        public int ProductNavigationId { get; set; }    // vk ; brauche ich set?
        public Product ProductNavigation { get; set; } = default!;
        public int ShoppingCartNavigationId { get; set; }   // vk ; brauche ich set?
        public ShoppingCart ShoppingCartNavigation { get; set; } = default!;

        protected ShoppingCartItem()
        { }

        public ShoppingCartItem(int itemCount)
        {
            ItemCount = itemCount;
        }
    }
}
