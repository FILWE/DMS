using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using System.Web.Mvc;

namespace DMS.Models
{
    public class Delivery
    {
        [ScaffoldColumn(false)]
        public int DeliveryID { get; set; }

        [DisplayName("Shop ID")]
        public int ShopID { get; set; }

        [DisplayName("Stock ID")]
        public int StockID { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "The delivery date is required")]
        public DateTime DeliveryDate { get; set; }

        [Required(ErrorMessage = "The quantity is required")]
        [Range(1, 2000)]
        public int Quantity { get; set; }
    }
}
