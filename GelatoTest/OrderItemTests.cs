using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GelatoDataLayer.Models;

namespace GelatoTests
{
    class OrderItemTests
    {
        [TestMethod()]
        public void BasketItemConstructorTest()
        {
            int productNumber = 88;
            int orderNumber = 26;
            int quantity = 1;
            IOrderItem target = new OrderItem(productNumber, orderNumber, quantity);
            Assert.AreEqual(2.49m, target.TotalValueOfBasketItem);
        }
    }
}
