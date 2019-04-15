using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMS.Models;

namespace DMS.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Data.DMSContext context)
        {
            Console.WriteLine("i came to initialise1");
            context.Database.EnsureCreated();
            Console.WriteLine("i came to initialise");


             if (context.Stocks.Any())
             {
                 return;   // DB has been seeded
             }

            var stock = new Stock[]
            {
            new Stock{Description = "Coke",Price = 10.0,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01") },
            new Stock{Description = "Fanta Pineapple",Price = 11.0,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},
            new Stock{Description = "Fanta Grape",Price = 11.0,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},
            new Stock{Description = "Fanta Orange",Price = 11.0,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},
            new Stock{Description = "Sparletta Pinenut",Price = 8.0,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},
            new Stock{Description = "Sparletta Raspberry",Price = 8.0,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},
            new Stock{Description = "Sparletta Iron Brew",Price = 8.5,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},
            new Stock{Description = "Sparletta Creme Soda",Price = 8.5,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},
            new Stock{Description = "Schweppes Lemon Twist",Price = 9,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},
            new Stock{Description = "Schweppes Granadilla Twist",Price = 9,ManufacturingDate = DateTime.Parse("2017-01-01"),StockInDate = DateTime.Parse("2018-04-01")},


            };
            foreach (Stock s in stock)
            {
                context.Stocks.Add(s);
            }
            context.SaveChanges();

            var shop = new Shop[]
            {
            new Shop{Name = "Pick 'n Pay",Contact = "0110101500"},
            new Shop{Name = "Woolworths",Contact = "0110101600"},
            new Shop{Name = "Spar",Contact = "01101016400"},
            new Shop{Name = "Shoprite",Contact = "0215801640"},
            new Shop{Name = "Checkers",Contact = "0215801642"},

            };
            foreach (Shop sh in shop)
            {
                context.Shops.Add(sh);
            }
            context.SaveChanges();

            var delivery = new Delivery[]
            {
            new Delivery{StockID = 1,ShopID = 1,DeliveryDate = DateTime.Parse("2019-09-01"), Quantity = 10 },
            new Delivery{StockID = 5,ShopID = 1,DeliveryDate = DateTime.Parse("2019-04-01"), Quantity = 20 },
            new Delivery{StockID = 3,ShopID = 5,DeliveryDate = DateTime.Parse("2019-11-01"), Quantity = 60 },
            new Delivery{StockID = 9,ShopID = 3,DeliveryDate = DateTime.Parse("2019-04-09"), Quantity = 100 },
            new Delivery{StockID = 7,ShopID = 4,DeliveryDate = DateTime.Parse("2019-09-21"), Quantity = 290 },


            };
            foreach (Delivery d in delivery)
            {
                context.Deliveries.Add(d);
            }
            context.SaveChanges();

        }
    }
}
