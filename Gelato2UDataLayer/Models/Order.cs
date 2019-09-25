using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GelatoDataLayer.Models
{
    [Table("Orders")]
    public class Order
    {
        [Column(Order = 0), Key, ForeignKey("OrderItems")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNumber { get; set; }
        public int CustomerNumber { get; set; }

        public int CustomerDiscount { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotalBeforeDiscount { get; set; }
        public int OrderStatus { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }


    }
}
