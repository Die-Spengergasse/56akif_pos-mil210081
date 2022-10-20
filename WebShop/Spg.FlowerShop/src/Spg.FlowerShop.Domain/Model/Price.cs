namespace Spg.FlowerShop.Domain.Model
{
    public class Price
    {
        public int Id { get; set; }

        public decimal Value { get; set; } = decimal.MinValue;

        public DateTime ValidFrom { get; set; }

        public DateTime? ValidTo { get; set; }

        public Product Product { get; set; } = default!;        
    }
}