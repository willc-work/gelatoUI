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
        public int OrderNumber { get; set; }
        public int CustomerNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public Decimal OrderTotal { get; set; }
        public int OrderStatus { get; set; }
        public bool Deliver { get; set; }

        public ICollection<BasketItem> OrderItems { get; set; }


    }
}
