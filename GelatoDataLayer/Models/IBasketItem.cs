using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoDataLayer.Models
{
    public interface IBasketItem
    {
        int OrderNumber { get; set; }
        int ProductNumber { get; set; }
        int Quantity { get; }
    }
}
