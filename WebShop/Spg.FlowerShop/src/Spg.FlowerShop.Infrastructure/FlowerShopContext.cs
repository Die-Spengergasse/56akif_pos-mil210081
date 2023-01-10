using Bogus;
using Microsoft.EntityFrameworkCore;
using Spg.FlowerShop.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FlowerShop.Infrastructure
{
    // 1. Diese Klasse muss von DBContext ableiten
    public class FlowerShopContext : DbContext
    {
        // 2. Die Tabellen der DB als Properties auflisten
        public DbSet<Customer> Customers => Set<Customer>(); 
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductCategory> ProductCategories => Set<ProductCategory>();
        public DbSet<ShoppingCart> ShoppingCarts => Set<ShoppingCart>();
        public DbSet<ShoppingCartItem> ShoppingCartItems => Set<ShoppingCartItem>();
        public DbSet<PaymentMethod> PaymentMethods=> Set<PaymentMethod>();
        public DbSet<Price> Prices=> Set<Price>();
        public DbSet<Review> Reviews=> Set<Review>();

        // za Adresu kein Set jer je Value Object

        // 3. Constructor
        // wie finde ich ein Datenbank - Connection string
        public FlowerShopContext()
        { }

        // wo ist meine DB und um welche geht es; Entity Framework findet DB
        public FlowerShopContext(DbContextOptions options)
            : base(options) 
        { }

        // 4. OnConfuguring() - waehrend die DB konfiguriert wird
        // Konfiguration vor DB Erstellung
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // if(!optionsBuilder.IsConfigured)    // if is not configured
            // {
              //  optionsBuilder.UseSqlite("Data Source = FlowerShop.db");
            //}
        }

        // 5. OnModelCreting() - waehrend die DB gemacht wird
        // Optionen waehrend DB Erstellung 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //PropertyInfo[] x = new Product("", "", "").GetType().GetProperties();
            //string pName = x[1].;

            // modelBuilder.Entity<Product>().ToTable("Produkte");

            modelBuilder.Entity<Product>().HasKey(p => p.ProductName);
            modelBuilder.Entity<Product>().Property(p => p.ProductName).IsRequired();

            modelBuilder.Entity<ProductCategory>().HasKey(p => p.Name);
            modelBuilder.Entity<ProductCategory>().Property(p => p.Name).IsRequired();

            modelBuilder.Entity<PaymentMethod>().HasKey(p => p.Name);
            modelBuilder.Entity<PaymentMethod>().Property(p => p.Name).IsRequired();

            /* nicht notwending, wird automatisch generiert
            modelBuilder.Entity<Price>().HasKey(p => p.Id);
            modelBuilder.Entity<Price>().Property(p => p.Id).IsRequired();

            modelBuilder.Entity<Customer>().HasKey(p => p.Id);
            modelBuilder.Entity<Customer>().Property(p => p.Id).IsRequired();

            modelBuilder.Entity<Review>().HasKey(p => p.Id);
            modelBuilder.Entity<Review>().Property(p => p.Id).IsRequired();

            modelBuilder.Entity<ShoppingCart>().HasKey(p => p.Id);
            modelBuilder.Entity<ShoppingCart>().Property(p => p.Id).IsRequired();

            modelBuilder.Entity<ShoppingCartItem>().HasKey(p => p.Id);
            modelBuilder.Entity<ShoppingCartItem>().Property(p => p.Id).IsRequired();
            */

            // [HasMany]

            // Value Object - Adresses
            modelBuilder.Entity<Customer>().OwnsOne(c => c.BillingAddress);
            modelBuilder.Entity<Customer>().OwnsOne(c => c.ShippingAddress); // Action, Datentyp Address
        }

        public void Seed()
        {
            Randomizer.Seed = new Random(1444112);

            List<Customer> customers = new Faker<Customer>("de").CustomInstantiator(f =>
                new Customer(
                    f.Random.Enum<Genders>(),
                    f.Random.Long(11111, 999999),
                    f.Name.FirstName(Bogus.DataSets.Name.Gender.Female),
                    f.Name.LastName(),
                    f.Internet.Email(),
                    f.Date.Between(DateTime.Now.AddYears(-60), DateTime.Now.AddYears(-16)),
                    f.Date.Between(DateTime.Now.AddYears(-5), DateTime.Now.AddDays(-2))
                    ))
                .Rules((f, c) => 
                {
                    if (c.Gender == Genders.Male)
                    {
                        c.FirstName = f.Name.FirstName(Bogus.DataSets.Name.Gender.Male);
                    }

                    // Shipping Address - preko Inita dodeljuje vrednosti
                    c.ShippingAddress = new ShippingAddress()
                    { 
                        City = f.Address.City(),
                        Number = f.Address.BuildingNumber(),
                        Street = f.Address.StreetName(),
                        Zip = f.Address.ZipCode()
                    };

                    // Billing Address
                    c.BillingAddress = new BillingAddress()
                    {
                        City = f.Address.City(),
                        Number = f.Address.BuildingNumber(),
                        Street = f.Address.StreetName(),
                        Zip = f.Address.ZipCode()
                    };
                })
                .Generate(10)
                .ToList();

            Customers.AddRange(customers);
            SaveChanges();

            List<ShoppingCart> shoppingCarts= new Faker<ShoppingCart>().CustomInstantiator(f =>
                new ShoppingCart(
                     Status.Check,
                     f.Date.Between(DateTime.Now.AddYears(-5), DateTime.Now.AddDays(-6))
                )
            ).Rules((f, s) => 
            {
                s.CustomerNavigation = f.Random.ListItem(customers);
                s.PaymentMethod = new PaymentMethod("PayPal"); // GRESKA
            })
            .Generate(100)
            .ToList();

            ShoppingCarts.AddRange(shoppingCarts);
            SaveChanges();

            /*
            List<PaymentMethod> paymentMethods = new Faker<PaymentMethod>().CustomInstantiator(f =>
                new PaymentMethod(
                    f.
                    )
                )
            */
            
        }
    }
}
