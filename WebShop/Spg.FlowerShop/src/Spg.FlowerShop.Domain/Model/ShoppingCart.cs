namespace Spg.FlowerShop.Domain.Model
{
    public enum Status // enumeration
    {
        Aktuell = 0,
        InBezahlung = 1,
        Check = 2,
        Abgeschlossen = 3 
    }

    public class ShoppingCart
    {
        public int Id { get; }

        public Status Status { get; set; }

        public DateTime? SoldOn { get; set; } //auto-calculated??? brauche ich set?

        public int CustomerNavigationId { get; set; }
        public Customer CustomerNavigation { get; set; } = default!; // du(dieser ShoppingCart) gehoerst einem CustomerNavigation

        private List<ShoppingCartItem> _shoppingCartItems = new(); // leere Liste, wie im DB

        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems;

        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; } = default!;

        public ShoppingCart(Status status, DateTime soldOn)
        {
            Status = status;
            SoldOn = soldOn;
        }
        protected ShoppingCart()
        { }
    }

}
