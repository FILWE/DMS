using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMS.Models;
namespace DMS.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Models.DMSContext context)
        {
            context.Database.EnsureCreated();


            if (context.Delivery.Any())
            {
                return;   // DB has been seeded
            }

            var stock = new Stock[]
            {
            new Stock{StockID = 1,Description = "Coke",Price = 10.0},
            new Stock{StockID = 2,Description = "Fanta Pineapple",Price = 11.0},
            new Stock{StockID = 3,Description = "Fanta Grape",Price = 11.0},
            new Stock{StockID = 4,Description = "Fanta Orange",Price = 11.0},
            new Stock{StockID = 5,Description = "Sparletta Pinenut",Price = 8.0},
            new Stock{StockID = 6,Description = "Sparletta Raspberry",Price = 8.0},
            new Stock{StockID = 7,Description = "Sparletta Iron Brew",Price = 8.5},
            new Stock{StockID = 8,Description = "Sparletta Creme Soda",Price = 8.5},
            new Stock{StockID = 9,Description = "Schweppes Lemon Twist",Price = 9},
            new Stock{StockID = 10,Description = "Schweppes Granadilla Twist",Price = 9},


            };
            foreach (Stock s in stock)
            {
                context.Stock.Add(s);
            }
            context.SaveChanges();

            var shop = new Shop[]
            {
            new Shop{ShopID = 1,Name = "Pick 'n Pay",Contact = "0110101500"},
            new Shop{ShopID = 2,Name = "Woolworths",Contact = "0110101600"},
            new Shop{ShopID = 3,Name = "Spar",Contact = "01101016400"},
            new Shop{ShopID = 4,Name = "Shoprite",Contact = "0215801640"},
            new Shop{ShopID = 5,Name = "Checkers",Contact = "0215801642"},

            };
            foreach (Shop sh in shop)
            {
                context.Shop.Add(sh);
            }
            context.SaveChanges();

            var delivery = new Delivery[]
            {
            new Delivery{DeliveryID = 1,StockID = 1,ShopID = 1,DeliveryDate = DateTime.Parse("2005-09-01"), Quantity = 10 },
            new Delivery{DeliveryID = 2,StockID = 5,ShopID = 1,DeliveryDate = DateTime.Parse("2009-04-01"), Quantity = 20 },
            new Delivery{DeliveryID = 3,StockID = 3,ShopID = 5,DeliveryDate = DateTime.Parse("2016-11-01"), Quantity = 60 },
            new Delivery{DeliveryID = 4,StockID = 9,ShopID = 3,DeliveryDate = DateTime.Parse("2019-04-09"), Quantity = 100 },
            new Delivery{DeliveryID = 5,StockID = 7,ShopID = 4,DeliveryDate = DateTime.Parse("2018-09-21"), Quantity = 290 },


            };
            foreach (Delivery d in delivery)
            {
                context.Delivery.Add(d);
            }
            context.SaveChanges();

        }
    }
}
