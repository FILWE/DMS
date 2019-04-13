using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DMS.Models
{
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public int ShopID { get; set; }
        public int Stock { get; set; }
        [DataType(DataType.Date)]
        public DateTime DeliveryDate { get; set; }
        public int Quantity { get; set; }
    }
}
