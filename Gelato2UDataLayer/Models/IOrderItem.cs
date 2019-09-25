using System;
using System.Collections.Generic;
using System.Text;

namespace GelatoDataLayer.Models
{
    public interface IOrderItem
    {
        int OrderNumber { get; set; }
        int ProductNumber { get; set; }
        int Quantity { get; }
    }
}
