using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GelatoDataLayer.Models;

namespace GelatoTests
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
            Assert.IsTrue(target.IsProductInBasket(productNumber));
        }

        [TestMethod()]
        public void IsProductInBasketTest()
        {
            OrderBasket target = new OrderBasket();
            int productNumber = 1;
            Assert.IsFalse(target.IsProductInBasket(productNumber));

        }
        [TestMethod()]
        public void RemoveItemTest()
        {
            int productNumber = 1;

            OrderBasket target = new OrderBasket();
            target.AddItem(productNumber, "Pancake Gelato", 2.49m, 3.5m, 3, " Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.");
            target.AddItem(2, "Cinamon Gelato", 3.22m, 4.0m, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
            target.AddItem(productNumber, "Muffin Gelato",1.89m, 2.49m, 4, "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.");
            target.AddItem(3, "Waffle Gelato", 2.22m, 2.7m, 3, "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            target.RemoveItem(productNumber);
            Assert.IsFalse(target.IsProductInBasket(productNumber));
        }


        /// <summary>
        ///A test for BasketTotal
        ///</summary>
        [TestMethod()]
        public void BasketTotalTest()
        {
            OrderBasket target = new OrderBasket(); // TODO: Initialize to an appropriate value
            string productName = "Gilet Gelato";
            target.AddItem(1, productName, 2.49m, 3.1m, 2, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(2, "Jambon Gelato", 3.22m, 3.99m, 3, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(1, productName, 2.49m, 3.99m, 4, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(3, "Gelato Gelato", 2.22m, 2.75m, 3, "Excepteur sint occaecat cupidatat non proident");
            Decimal actual;
            actual = target.BasketTotal;
            decimal expected = 31.26m;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NumberOfProductsTest()
        {
            OrderBasket target = new OrderBasket(); // TODO: Initialize to an appropriate value
            target.AddItem(1,"Beurre Gelato", 50.0m, 55.5m, 5, "Just some sort of desc");
            target.AddItem(2,"Pain Gelato", 100.55m, 120.5m, 30, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(4,"Vino Veitas Gelato", 100.47m, 110.5m, 1, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(6,"Strawberry Gelato", 1m, 1.5m, 5, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(6, "Strawberry Gelato", 1m, 1.5m, 5, "Excepteur sint occaecat cupidatat non proident");
            int expectedNumberOfProducts = 4;

            Assert.AreEqual(expectedNumberOfProducts, target.NumberOfProducts);
        }

        [TestMethod()]
        public void NumberOfItemsTest()
        {
            OrderBasket target = new OrderBasket();
            target.AddItem(1, "Beurre Gelato", 50.0m, 55.5m, 10, "Just some sort of desc");
            target.AddItem(2, "Pain Gelato", 100.55m, 120.5m, 30, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(4, "Vino Veritas Gelato", 100.47m, 110.5m, 1, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(6, "Strawberry Gelato", 1m, 1.5m, 11, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(6, "Strawberry Gelato", 1m, 1.5m, 5, "Excepteur sint occaecat cupidatat non proident");
            int expectedNumberOfItems = 57;

            Assert.AreEqual(expectedNumberOfItems, target.NumberOfItems);
        }


        //A test to ClearBasket
        [TestMethod()]
        public void ClearBasketTest()
        {
            OrderBasket target = new OrderBasket();
            target.AddItem(1, "Beurre Gelato", 50.0m, 55.5m, 10, "Just some sort of desc");
            target.AddItem(2, "Pain Gelato", 100.55m, 120.5m, 30, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(4, "Vino Veritas Gelato", 100.47m, 110.5m, 1, "Excepteur sint occaecat cupidatat non proident");
            target.AddItem(6, "Strawberry Gelato", 1m, 1.5m, 11, "Excepteur sint occaecat cupidatat non proident");
            target.ClearBasket();
            Assert.AreEqual(0, target.BasketItems.Count);
        }

    }
}
