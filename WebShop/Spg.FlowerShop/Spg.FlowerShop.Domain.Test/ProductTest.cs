using Microsoft.EntityFrameworkCore;
using Spg.FlowerShop.Domain.Model;
using Spg.FlowerShop.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FlowerShop.Domain.Test
{
    // Unit test - eine Methode test die andere
    // Red to green approach  - Test Driven Development TDD
    // zuerst den Test schreiben, und dann die Methode
    public class ProductTest
    {
        private FlowerShopContext GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder(); 
            optionsBuilder.UseSqlite("Data Source=FlowerShop_Test.db");

            FlowerShopContext db = new FlowerShopContext(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        [Fact]
        public void SeedDb()
        { 
            FlowerShopContext db = GenerateDb();
            db.Seed();
            Assert.True(true);
        }

        [Fact]
        public void ProductCategory_Add_OneEntity_SuccessTest()
        { 
            FlowerShopContext db = GenerateDb();
            ProductCategory newProductCategory = new ("Frühlingsblumen", "Tulpen"); 

            db.ProductCategories.Add(newProductCategory);
            db.SaveChanges();

            int actual = db.ProductCategories.Count();
            Assert.Equal(1, actual);
        }

        // Annotation Fact - diese Methode ist Fact; das was drinnen steht muss funktionieren
        // wenn es nicht funktioniert, ist nicht wegen dieser Methode 
        // die Methode hat kein Rueckgabetyp
        // wenig Codezeile pro Methode 
        [Fact] // stavljam UVEK!!! uz test Metodu!
        public void Product_Add_OneEntity_SuccessTest()
        {
            // AAA - ein Unit test besteht immer aus diese drei Teilen
            // 1. Arrange (Object instanzieren)
            FlowerShopContext db = GenerateDb();
            // wir wollten Product testen
            //Product newProduct = new  ("Tulpen", "gelbe Tulpen", " ");

            //ProductCategory newProductCategory = new ProductCategory ("FRBL", "Frühlingsblumen ");
            //newProduct.ProductCategoryNavigation= newProductCategory;


            Product newProduct = new("Tulpen", "gelbe Tulpen", " ")
            {
               ProductCategoryNavigation = new ProductCategory("FRBL", "Frühlingsblumen ")
            };

            // 2. Act - mach was
            // Microsoft hat schon Add and SaveChanges getestet; es gibt schon tests
            db.Products.Add(newProduct);
            db.SaveChanges();

            // 3. Assert - vergleichen: ob in DB wirklich existiert
            // Assert.True(db.Products.Any()); // ueberprueft, ob eine drinnen ist
            // Assert.Equal(expected, actual)
            int actual = db.Products.Count();
            // vergleich 1 mit dem erwarteten Ergebnis
            Assert.Equal(1, actual);
        }

        [Fact]
        public void PaymentMethod_Add_OneEntity_SuccessTest()
        {
            FlowerShopContext db = GenerateDb();
            PaymentMethod newPaymentMethod = new ("MaestroCard");

            db.PaymentMethods.Add(newPaymentMethod);
            db.SaveChanges();

            int actual = db.PaymentMethods.Count();
            Assert.Equal(1, actual);
        }
    }
}
