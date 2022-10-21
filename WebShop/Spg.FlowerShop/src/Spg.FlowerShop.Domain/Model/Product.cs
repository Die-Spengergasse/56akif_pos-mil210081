using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FlowerShop.Domain.Model
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public decimal CurrentPrice { get; set; }

        public string ProductDescription { get; set; } = string.Empty;

        public ProductCategory ProductCategory { get; set; } = default!;

        public string ProductImage { get; set; } = string.Empty;

        public List<Price> Prices { get; set; } = new(); 

        public List<Review> Reviews { get; set; } = new();

        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new();
    }
}
