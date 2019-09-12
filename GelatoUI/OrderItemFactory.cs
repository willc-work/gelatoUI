using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoUI
{
    public static class OrderItemFactory
    {
        public static BasketItem GetOrderItem(int productNumber, string productName, decimal price, decimal recommendedRetailPrice, int quantity, string description)
        {
            return new BasketItem(productNumber, productName, price,recommendedRetailPrice, quantity, description);
        }
    }
}
