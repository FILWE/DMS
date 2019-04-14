

































using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMS.Models
{
    public class Stock
    {
        public int StockID { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public ICollection<Delivery> Deliveries { get; set; }
    }
}
