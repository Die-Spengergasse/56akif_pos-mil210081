using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FlowerShop.Domain.Model
{
    public enum Status // enumeration
    {
        Aktuell = 0,
        InBezahlung = 1,
        Check = 2,
        Abgeschlossen = 3 
    }

    public class ShoppingCart
    {
        public Status Status { get; set; } 

        public int Id { get; set; }

        public int ItemsCount { get; set; }

        public DateTime SoldOn { get; set; } 

        public Customer CustomerNavigation { get; set; } = default!; // du(dieser ShoppingCart) gehoerst einem Customer

        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = new(); // leere Liste, wie im DB

        public Status StatusNavigation { get; set; } = default!;

        public PaymentMethod PaymentMethod { get; set; } = default!;  
    }

}
