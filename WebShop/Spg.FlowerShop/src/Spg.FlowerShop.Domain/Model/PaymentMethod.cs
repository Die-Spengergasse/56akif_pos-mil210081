namespace Spg.FlowerShop.Domain.Model
{
    public class PaymentMethod
    {
        public int Id { get; set; }

        public string Name = string.Empty;

        public List<ShoppingCart> ShoppingCarts { get; set; } = new();
    }
}