using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GelatoDataModel.Models
{
    [Table("Orders")]
    public class Order
    {
        [Column(Order = 0), Key, ForeignKey("OrderItems")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int OrderItemNumber { get; set; }
        public int OrderNumber { get; set; }
        public DateTime CustomerNumber { get; set; }
        public Decimal Quantity { get; set; }

        public ICollection<BasketItem> OrderItems { get; set; }


    }
}
