namespace Spg.FlowerShop.Domain.Model
{
    public class Price
    {
        public int Id { get; private set; }

        public decimal Value { get; set; } = decimal.MinValue;

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public string ProductNavigationId { get; set; } = string.Empty; 
        public Product ProductNavigation { get; set; } = default!;

        public Price(decimal value, DateTime validFrom, DateTime? validTo)
        {
            Value = value;
            ValidFrom = validFrom;
            ValidTo = validTo;
        }

        protected Price()
        { }
    }
}