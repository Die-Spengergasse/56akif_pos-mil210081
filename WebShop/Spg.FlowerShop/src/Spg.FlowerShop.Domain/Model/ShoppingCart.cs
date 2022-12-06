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
        public Status Status { get; set; }

        public int Id { get; }

        public int ItemsCount { get; set; }

        public DateTime SoldOn { get; set; } //auto-calculated???

        public Customer CustomerNavigation { get; set; } = default!; // du(dieser ShoppingCart) gehoerst einem Customer

        public List<ShoppingCartItem> _shoppingCartItems = new(); // leere Liste, wie im DB

        public IReadOnlyList<ShoppingCartItem> ShoppingCartItems => _shoppingCartItems;


        public PaymentMethod PaymentMethod { get; set; } = default!;

        public ShoppingCart(Status status, int id, int itemsCount, DateTime soldOn, Customer customerNavigation, PaymentMethod paymentMethod)
        {
            Status = status;
            Id = id;
            ItemsCount = itemsCount;
            SoldOn = soldOn;
            CustomerNavigation = customerNavigation;
            PaymentMethod = paymentMethod;
        }

        public ShoppingCart()
        {
        }
    }

}
