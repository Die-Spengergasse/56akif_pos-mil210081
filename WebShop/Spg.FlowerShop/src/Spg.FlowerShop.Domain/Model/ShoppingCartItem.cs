using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FlowerShop.Domain.Model
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }

        public int ItemCount { get; set; }

        public Product Product { get; set; } = default!;

        public ShoppingCart ShoppingCart { get; set; } = default!;
    }
}
