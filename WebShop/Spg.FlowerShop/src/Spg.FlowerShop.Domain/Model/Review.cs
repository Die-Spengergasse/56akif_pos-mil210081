namespace Spg.FlowerShop.Domain.Model
{
    public class Review
    {
        public string Id { get; set; } = string.Empty;

        public Customer Customer { get; set; } = default!;  

        public Product Product { get; set; } = default!;

        public DateTime ReviewDate { get; set; } 

        public int ReviewScore { get; set; }

        public string Description { get; set; } = string.Empty;
  
    }
}