using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoUI
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

        /// Returns the total number of distinct product types
        public int NumberOfProducts
        {
            get
            {
                return BasketItems.Count;
            }
        }

        /// Total cost of all items in basket combined
        public decimal BasketTotal
        {
            get
            {
                decimal totalPrice = 0m;

                foreach (BasketItem bi in BasketItems)
                {
                    totalPrice += bi.totalValueOfBasketItem;
                }
                return totalPrice;
            }
        }
        /// Returns the total quantity of items in all products
        /// </summary>
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

        public void AddProduct(int productNumber, string productName, decimal price, decimal recommendedRetailPrice, int quantity, string description)
        {
            BasketItem basketItem;
            bool itemFound = FindBasketItemByProductNumber(productNumber, out basketItem);

            if (itemFound)
                basketItem.IncreaseQuantity(quantity);
            else
            {
                basketItem = OrderItemFactory.GetOrderItem(productNumber, productName, price, recommendedRetailPrice, quantity, description);
                this.BasketItems.Add(basketItem);
            }
        }

        private bool FindBasketItemByProductNumber(int productNumber, out BasketItem foundItem)
        {
            foundItem = null;

            if (!this.BasketItems.Any(oItem => oItem.ProductNumber == productNumber)) //Check that a product with the productName exists
                return false; // False if no product found with specified name

            var specifiedItem = this.BasketItems.FirstOrDefault(oItem => oItem.ProductNumber == productNumber);//LINQ query to get the first BasketItem with the specified productName. Case insensitive.

            foundItem = (BasketItem)specifiedItem;

            return true;
        }
    }
}
