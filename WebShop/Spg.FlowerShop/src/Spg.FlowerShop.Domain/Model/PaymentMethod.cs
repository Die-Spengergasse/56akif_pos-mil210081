namespace Spg.FlowerShop.Domain.Model
{
    public class PaymentMethod
    {
        public string Name { get; set; } = string.Empty;

        private List<ShoppingCart> _shoppingCarts = new();
        public IReadOnlyList<ShoppingCart> ShoppingCarts => _shoppingCarts;

        public PaymentMethod(string name)
        {
            Name = name;
        }

        protected PaymentMethod()
        { }
    }
}