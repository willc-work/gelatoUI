using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoDataLayer.Models
{
    [Table("Products")]
    public class Product
    {
        [Column(Order = 0), Key, ForeignKey("OrderItems")]
        public int ProductNumber { get; set; }
        public string Description { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public decimal RecommendedRetailPrice { get; set; }

        public ICollection<BasketItem> OrderItems { get; set; }
    }
}
