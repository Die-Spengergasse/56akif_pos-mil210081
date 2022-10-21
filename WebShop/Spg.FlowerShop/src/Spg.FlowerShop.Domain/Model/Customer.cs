using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FlowerShop.Domain.Model
{
    public enum Genders // enumeration
    { 
        Male = 0, 
        Female = 1, 
        Other = 2
    }

    public class Customer
    {

        public Genders Gender { get; set; }

        public string CustomerNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } // = DateTime.MinValue; [optional]
        public string ShippingAddress { get; set; } = string.Empty; // default Wert
        public string BillingAddress { get; set; } = string.Empty; 
        public DateTime RegistrationDateTime { get; set; } 

        // TO DO : Authentification 
        // TO DO : Username
        // TO DO : Password string

        // 1 Customer kann mehr ShoppingCarts haben
        public List<ShoppingCart> ShoppingCarts { get; set; } = new();

        public List<Review> Reviews { get; set; } = new(); 

    }
}
