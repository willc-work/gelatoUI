using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoUI
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

        int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                    quantity = value;
            }
        }
        public string Description { get; set; }
        public decimal totalValueOfBasketItem
        {
            get
            {
                return Price * quantity;
            }
        }
        public int IncreaseQuantity(int quantity)
        {
            return Quantity += quantity;
        }

        public int DencreaseQuantity(int quantity)
        {
            return Quantity -= quantity;
        }

    }
}
