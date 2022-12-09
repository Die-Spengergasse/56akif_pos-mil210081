namespace Spg.FlowerShop.Domain.Model
{
    public class Review
    {
        public int Id { get; }

        public int CustomerNavigationId { get; set; }
        public Customer CustomerNavigation { get; set; } = default!;

        public string ProductNavigationId { get; set; } = string.Empty; 
        public Product ProductNavigation { get; set; } = default!;

        public DateTime ReviewDate { get; } 

        public int ReviewScore { get; set; }

        public string Description { get; set; } = string.Empty;

        public Review(DateTime reviewDate, int reviewScore, string description)
        {
            ReviewDate = reviewDate;
            ReviewScore = reviewScore;
            Description = description;
        }
        protected Review()
        { }
 
    }
}