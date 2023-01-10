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
        public int Id { get; private set; } // zbog OR Mappera mora da postoji set!
        public Genders Gender { get; set; }
        public long CustomerNumber { get; private set; }  // long
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime? BirthDate { get; set; } // = DateTime.MinValue; [optional]
        public ShippingAddress? ShippingAddress { get; set; } = default!; //
        public BillingAddress? BillingAddress { get; set; } = default!; 
        public DateTime RegistrationDateTime { get; }

        // 1 CustomerNavigation kann mehr ShoppingCarts haben
        private List<ShoppingCart> _shoppingCarts = new();
        public IReadOnlyList<ShoppingCart> ShoppingCarts => _shoppingCarts;

        private List<Review> _reviews = new();
        public IReadOnlyList<Review> Reviews => _reviews;

        public Customer(Genders gender, long customerNumber, string firstName, string lastName, string email, DateTime birthDate, DateTime registrationDateTime)
        {
            Gender = gender;
            CustomerNumber = customerNumber;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDate = birthDate;
            RegistrationDateTime = registrationDateTime;
        }

        protected Customer()
        { }
        
        // TO DO : Authentification 
        // TO DO : Username
        // TO DO : Password string
    }
}
