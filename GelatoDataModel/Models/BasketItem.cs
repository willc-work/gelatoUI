﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GelatoDataModel.Models
{
    [Table("OrderItems")]
    public class BasketItem : IBasketItem
    {
        public BasketItem()
        {

        }

        public BasketItem(int productNumber, string productName, decimal price, decimal recommendedRetailPrice, int quantity, string description)
        {
            this.ProductNumber = productNumber;
            this.ProductName = productName;
            this.Price = price;
            this.RecommendedRetailPrice = recommendedRetailPrice;
            this.Quantity = quantity;
            this.Description = description;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        // Not currently in use, remove clears the item from the basket entirely
        // Potential improvment to add a remove quantity button to reduce quantity by 1 each click
        public int DecreaseQuantity(int quantity)
        {
            return Quantity -= quantity;
        }

    }
}
