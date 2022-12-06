namespace Spg.FlowerShop.Domain.Model
{
    public class ProductCategory
    {
        public int Id { get; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<Product> _products = new();
        public IReadOnlyList<Product> Products => _products;

        public ProductCategory(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public ProductCategory()
        {
        }
    }
}