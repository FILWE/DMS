using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DMS.Models
{
    public class Stock
    {
        [ScaffoldColumn(false)]
        public int StockID { get; set; }

        [Required(ErrorMessage = "The description is required")]
        [Range(1, 2000)]
        public string Description { get; set; }

        [Required(ErrorMessage = "The quantity is required")]
        [Range(1, 1000000)]
        public double Price { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "The manufacturing date is required")]
        public DateTime ManufacturingDate { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "The stock-in date is required")]
        public DateTime StockInDate { get; set; }


        public ICollection<Delivery> Deliveries { get; set; }
       // public object Delivery { get; internal set; }
    }
}
