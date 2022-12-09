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
        public int Id { get; }
        public Genders Gender { get; set; }
        public string CustomerNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; } // = DateTime.MinValue; [optional]
        public string ShippingAddress { get; set; } = string.Empty; 
        public string? BillingAddress { get; set; } = string.Empty; 
        public DateTime RegistrationDateTime { get; }

        // 1 CustomerNavigation kann mehr ShoppingCarts haben
        private List<ShoppingCart> _shoppingCarts = new();
        public IReadOnlyList<ShoppingCart> ShoppingCarts => _shoppingCarts;

        private List<Review> _reviews = new();
        public IReadOnlyList<Review> Reviews => _reviews;
        public Customer(Genders gender, string customerNumber, string firstName, string lastName, string email, DateTime birthDate, string shippingAddress, string billingAddress, DateTime registrationDateTime)
        {
            Gender = gender;
            CustomerNumber = customerNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            ShippingAddress = shippingAddress;
            BillingAddress = billingAddress;
            RegistrationDateTime = registrationDateTime;
        }

        protected Customer()
        { }

        // TO DO : Authentification 
        // TO DO : Username
        // TO DO : Password string
    }
}
