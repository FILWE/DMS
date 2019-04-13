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
            new Stock{StockID = 1,Description = "Fanta",Price = 10.0},
            new Stock{StockID = 2,Description = "Coke",Price = 10.0},

            };
            foreach (Stock s in stock)
            {
                context.Stock.Add(s);
            }
            context.SaveChanges();

            var shop = new Shop[]
            {
            new Shop{ShopID = 1,Name = "PNP",Contact = "01101010500"},
            new Shop{ShopID = 2,Name = "woolies",Contact = "01101010500"},

            };
            foreach (Shop sh in shop)
            {
                context.Shop.Add(sh);
            }
            context.SaveChanges();

            var delivery = new Delivery[]
            {
            new Delivery{DeliveryID = 1,Stock = 1,ShopID = 1,DeliveryDate = DateTime.Parse("2005-09-01"), Quantity = 10 },


            };
            foreach (Delivery d in delivery)
            {
                context.Delivery.Add(d);
            }
            context.SaveChanges();

        }
    }
}
