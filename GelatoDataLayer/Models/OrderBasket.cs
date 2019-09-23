using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoDataLayer.Models
{
    public class OrderBasket
    {
        public OrderBasket()
        {
            BasketItems = new List<BasketItem>();
        }
        public List<BasketItem> BasketItems
        {
            get;
            private set;
        }

        /// Returns the total individual product types
        public int NumberOfProducts
        {
            get
            {
                return BasketItems.Count;
            }
        }

        public bool IsProductInBasket(int productNumber)
        {
            if (this.BasketItems.Any(x => x.ProductNumber.Equals(productNumber))) //Check that a product with the productName exists
                return true; //  Product found

            return false;
        }


        /// Returns total cost of all items combined
        public decimal BasketTotal
        {
            get
            {
                decimal totalPrice = 0m;

                foreach (BasketItem bi in BasketItems)
                {
                    totalPrice += bi.TotalValueOfBasketItem;
                }
                return totalPrice;
            }
        }
        /// Returns the total individual items across all products
        public int NumberOfItems
        {
            get
            {
                int totalQuantity = 0;
                foreach (BasketItem orderItem in this.BasketItems)
                {
                    totalQuantity += orderItem.Quantity;
                }
                return totalQuantity;
            }
        }

        public void AddItem(int productNumber, string productName, decimal price, decimal recommendedRetailPrice, int quantity, string description)
        {
            BasketItem basketItem;
            bool itemFound = SearchBasketUsingProductNumber(productNumber, out basketItem);

            if (itemFound)
                basketItem.IncreaseQuantity(quantity);
            else
            {
                basketItem = OrderItemFactory.GetOrderItem(productNumber, productName, price, recommendedRetailPrice, quantity, description);
                this.BasketItems.Add(basketItem);
            }
        }

        /// removes the quantity from a product
        public void RemoveItem(int productNumber)
        {
            BasketItem specifiedItem;
            if (SearchBasketUsingProductNumber(productNumber, out specifiedItem))
            {
                //specifiedItem.RemoveItem(specifiedItem.Quantity);
                this.BasketItems.Remove(specifiedItem);
            }
        }

        public void ClearBasket()
        {
            this.BasketItems.Clear();
        }

        private bool SearchBasketUsingProductNumber(int productNumber, out BasketItem foundItem)
        {
            foundItem = null;

            if (!this.BasketItems.Any(x => x.ProductNumber == productNumber)) //Check that a product with the productName exists
                return false; // False if no product found with specified name

            var specifiedItem = this.BasketItems.FirstOrDefault(oItem => oItem.ProductNumber == productNumber);//LINQ query to get the first BasketItem with the specified productName. Case insensitive.

            foundItem = (BasketItem)specifiedItem;

            return true;
        }
    }
}
