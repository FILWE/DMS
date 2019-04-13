using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DMS.Models;

namespace DMS.DMSViewModels
{
    public class DeliveryIndexData
    {
        public IEnumerable<Stock> Stock { get; set; }
        public IEnumerable<Shop> Shops { get; set; }
        public IEnumerable<Delivery> Deliveries { get; set; }
    }
}
