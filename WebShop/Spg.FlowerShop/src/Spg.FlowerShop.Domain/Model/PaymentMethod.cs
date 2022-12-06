namespace Spg.FlowerShop.Domain.Model
{
    public class PaymentMethod
    {
        public int Id { get; }

        public string Name = string.Empty;

        public List<ShoppingCart> _shoppingCarts = new();
        public IReadOnlyList<ShoppingCart> ShoppingCarts => _shoppingCarts;

        public PaymentMethod(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public PaymentMethod()
        {
        }
    }
}