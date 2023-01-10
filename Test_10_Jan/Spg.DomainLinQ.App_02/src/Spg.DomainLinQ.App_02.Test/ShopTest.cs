using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App_02.Test
{
    public class ShopTest
    {
        private Shop2000Context GenerateDb()
        {
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
            optionsBuilder.UseSqlite("Data Source=./../../../Shop2000.db");

            Shop2000Context db = new Shop2000Context(optionsBuilder.Options);
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            return db;
        }

        [Fact]
        public void SeedDb()
        {
            Shop2000Context db = GenerateDb();
            db.Seed();
            Assert.True(true);
        }

        [Fact]
        public void Shop_Add_OneEntity_SuccessTest()
        {
            Shop2000Context db = GenerateDb();
            Shop newShop = new Shop(
                "Billa",
                Guid.NewGuid()
                );

            db.Shops.Add(newShop);
            db.SaveChanges();

            int actual = db.Shops.Count();
            Assert.Equal(1, actual);
        }

        [Fact]
        public void User_Add_OneEntity_SuccessTest()
        {
            Shop2000Context db = GenerateDb();
            User newUser = new User(
                12345,
                Guid.NewGuid(),
                "Lana",
                "Mili",
                "mili@gmail.com",
                Gender.FEMALE,
                new Shop(
                    "Billa",
                    Guid.NewGuid()
                    ),
                new Address("street", "zip", "city", "12"),
                new Address("street2", "zip2", "city2", "13")
                );

            db.Users.Add(newUser);
            db.SaveChanges();

            int actual = db.Users.Count();
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Product_Add_OneEntity_SuccessTest()
        {
            Shop2000Context db = GenerateDb();
            Product newProduct = new Product(
                "descript",
                "lalal",
                2,
                null,
                null,
                new Shop(
                    "Billa",
                    Guid.NewGuid()
                    )
                );

            db.Products.Add(newProduct);
            db.SaveChanges();

            int actual = db.Products.Count();
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Supplier_Add_OneEntity_SuccessTest()
        {
            Shop2000Context db = GenerateDb();
            Supplier newSupplier = new Supplier(
                "descript",
                "lalal",
                "lalal2",
                Guid.NewGuid(),
                new Address("street", "zip", "city", "12"),
                new Address("street2", "zip2", "city2", "13")
                );

            db.Suppliers.Add(newSupplier);
            db.SaveChanges();

            int actual = db.Suppliers.Count();
            Assert.Equal(1, actual);
        }

        [Fact]
        public void Price_Add_OneEntity_SuccessTest()
        {
            Shop2000Context db = GenerateDb();
            Price newPrice = new Price(
                100,
                20,
                DateTime.UtcNow.AddDays(1),
                Guid.NewGuid(),
                new Product(
                    "descript",
                    "lalal",
                    2,
                    null,
                    null,
                    new Shop(
                        "Billa",
                        Guid.NewGuid()
                        )
                    )   
                );

            db.Prices.Add(newPrice);
            db.SaveChanges();

            int actual = db.Prices.Count();
            Assert.Equal(1, actual);
        }
    }
}
