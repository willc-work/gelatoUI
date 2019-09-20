using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace GelatoDataLayer.Models
{
    [Table("OrderItems")]
    public class OrderItem : IOrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderNumber, int productNumber, int quantity)
        {
            this.OrderNumber = orderNumber;
            this.ProductNumber = productNumber;
            this.Quantity = quantity;
        }

        public int OrderItemNumber { get; set; }
        public int OrderNumber { get; set; }
        public int ProductNumber { get; set; }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                    quantity = value;
            }
        }

        public int CompareTo(IOrderItem other)
        {
            throw new NotImplementedException();
        }
    }
}
