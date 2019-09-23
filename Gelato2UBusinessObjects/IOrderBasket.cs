using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace GelatoBusinessObjects
{
    public interface IOrderBasket
    {
        List<BasketItem> BasketItems { get; }
        int NumberOfProducts { get; }
        int NumberOfItems { get; }
        decimal BasketTotal { get; }


        void AddItem(int productNumber, string productName, decimal price, decimal recommendedRetailPrice, int quantity, string description);
        void RemoveItem(int productNumber);
        void ClearBasket();

    }
}
