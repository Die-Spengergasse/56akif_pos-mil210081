namespace Spg.FlowerShop.Domain.Model
{
    public class Price
    {
        public int Id { get; }

        public decimal Value { get; set; } = decimal.MinValue;

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public Product Product { get; set; } = default!;

        public Price(int id, decimal value, DateTime validFrom, DateTime? validTo, Product product)
        {
            Id = id;
            Value = value;
            ValidFrom = validFrom;
            ValidTo = validTo;
            Product = product;
        }
        public Price()
        {
        }
    }
}