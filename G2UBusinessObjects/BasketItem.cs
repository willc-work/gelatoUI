using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoBusinessObjects
{
    public class BasketItem
    {
        public BasketItem(int productNumber, string productName, decimal price, decimal recommendedRetailPrice, int quantity, string description)
        {
            this.ProductNumber = productNumber;
            this.ProductName = productName;
            this.Price = price;
            this.RecommendedRetailPrice = recommendedRetailPrice;
            this.Quantity = quantity;
            this.Description = description;
        }

        public int ProductNumber { get; set; }
        public int OrderNumber { get; set; }
        public string ProductName
        {
            get; private set;
        }

        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0)
                    price = value;
            }
        }
        public decimal RecommendedRetailPrice { get; set; }

        private int quantity;

        //quantity should always be greater than 1
        public int Quantity
        {
            get { return quantity; }
            private set
            {
                if (value >= 0)
                    quantity = value;
            }
        }
        public string Description { get; set; }
        public decimal TotalValueOfBasketItem
        {
            get
            {
                return Price * quantity;
            }
        }
        // add extra item(s) of the same type without creating a new entry in the list
        public int IncreaseQuantity(int quantity)
        {
            return Quantity += quantity;
        }

    }
}
