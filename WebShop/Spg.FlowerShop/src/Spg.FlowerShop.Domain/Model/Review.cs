namespace Spg.FlowerShop.Domain.Model
{
    public class Review
    {
        public string Id { get; } = string.Empty;

        public Customer Customer { get; set; } = default!;  

        public Product Product { get; set; } = default!;

        public DateTime ReviewDate { get; set; } 

        public int ReviewScore { get; set; }

        public string Description { get; set; } = string.Empty;

        public Review(string id, Customer customer, Product product, DateTime reviewDate, int reviewScore, string description)
        {
            Id = id;
            Customer = customer;
            Product = product;
            ReviewDate = reviewDate;
            ReviewScore = reviewScore;
            Description = description;
        }
        public Review()
        {
        }

    }
}