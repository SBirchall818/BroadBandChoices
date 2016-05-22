using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketLogic.Basket;
using BasketLogic.BasketItems;

namespace BasketLogicTests
{
    [TestClass]
    public class BasketRulesIntegrationTests
    {
        [TestMethod]
        public void BasketHas1Bread1Butter1Milk()
        {
            Basket basket = new Basket();
            BasketItemHelper.LoadBasketItems(ref basket,
                butters: 1,
                milks: 1,
                breads: 1);

            decimal total = basket.Total;
            Assert.AreEqual(2.95m, total);
        }

        [TestMethod]
        public void BasketHas2ButterAnd2Bread()
        {
            Basket basket = new Basket();
            BasketItemHelper.LoadBasketItems(ref basket, 
                butters: 2, 
                milks: 0,
                breads: 2);

            decimal total = basket.Total;
            Assert.AreEqual(3.10m, total);
        }

        [TestMethod]
        public void BasketHas4Milks()
        {
            Basket basket = new Basket();
            BasketItemHelper.LoadBasketItems(ref basket,
                butters: 0,
                milks: 4,
                breads: 0);

            decimal total = basket.Total;
            Assert.AreEqual(3.45m, total);
        }

        [TestMethod]
        public void BasketHas2Butter1BreadAnd8Milk()
        {
            Basket basket = new Basket();
            BasketItemHelper.LoadBasketItems(ref basket,
                butters: 2,
                milks: 8,
                breads: 1);

            decimal total = basket.Total;
            Assert.AreEqual(9.00m, total);
        }
    }
}
