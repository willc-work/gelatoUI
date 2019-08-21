using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoUI
{
    class BasketItem
    {
        private String productNumber;
        private String productName;
        private Decimal price;
        private Decimal recommendedRetailPrice;
        private int quantity;
        private String description;
        private String totalValueOfBasketItem;

        public BasketItem(string productNumber, string productName, decimal price, decimal recommendedRetailPrice, int quantity, string description, string totalValueOfBasketItem)
        {
            this.ProductNumber = productNumber;
            this.ProductName = productName;
            this.Price = price;
            this.RecommendedRetailPrice = recommendedRetailPrice;
            this.Quantity = quantity;
            this.Description = description;
        }

        public string ProductNumber { get => productNumber; set => productNumber = value; }
        public string ProductName { get => productName; set => productName = value; }
        public decimal Price { get => price; set => price = value; }
        public decimal RecommendedRetailPrice { get => recommendedRetailPrice; set => recommendedRetailPrice = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Description { get => description; set => description = value; }
        public string TotalValueOfBasketItem { get => totalValueOfBasketItem; set => totalValueOfBasketItem = value; }

        private void totalValue()
        {
            var totalPrice = price * quantity;

        }
    }
}
