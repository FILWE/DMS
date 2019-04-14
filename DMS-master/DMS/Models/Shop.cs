using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMS.Models
{
    public class Shop
    {
        public int ShopID { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }

        public ICollection<Delivery> Deliveries { get; set; }
    }
}
