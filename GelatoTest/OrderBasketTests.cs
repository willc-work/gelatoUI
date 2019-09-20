using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GelatoDataLayer.Models;

namespace GelatoTest
{
    [TestClass]
    public class OrderBasketTests
    {
        [TestMethod]
        public void AddItemTest()
        {
            OrderBasket target = new OrderBasket();
            int productNumber = 1;
            string productName = "Apfel Gelato";
            Decimal price = 5m;
            string description = "Apple and cinamon";
            Decimal recommendedRetailPrice = 7.2m;
            target.AddItem(productNumber, productName, price, recommendedRetailPrice, 5, description);
            Assert.IsTrue(target.IsProductInBasket(productName));
        }
    }
}
