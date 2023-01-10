namespace Spg.FlowerShop.Domain.Model
{
    public class ProductCategory
    {
        public string Name { get; private set; } = string.Empty; // pk

        public string Description { get; set; } = string.Empty;

        private List<Product> _products = new();
        public IReadOnlyList<Product> Products => _products;

        public ProductCategory(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public ProductCategory()
        { }
    }
}