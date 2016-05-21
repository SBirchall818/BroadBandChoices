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
            basket.AddItem(new BreadItem());
            basket.AddItem(new ButterItem());
            basket.AddItem(new MilkItem());

            decimal total = basket.Total;
            Assert.AreEqual(2.95m, total);
        }

        [TestMethod]
        public void BasketHas2ButterAnd2Bread()
        {
            Basket basket = new Basket();
            basket.AddItem(new ButterItem());
            basket.AddItem(new ButterItem());
            basket.AddItem(new BreadItem());
            basket.AddItem(new BreadItem());

            decimal total = basket.Total;
            Assert.AreEqual(3.10m, total);
        }
    }
}
