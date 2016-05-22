using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketLogic.BasketItems;
using System.Collections.Generic;
using BasketLogic.Rules;

namespace BasketLogicTests
{
    [TestClass]
    public class EveryFourthMilkFreeTests
    {
        [TestMethod]
        public void DoesNotApplyIfListIsEmpty()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();

            decimal result = rule.Apply(basketItems);
            Assert.AreEqual(0.0m, result);
        }

        [TestMethod]
        public void AppliesIfThereAreFourMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 4, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = -MilkItem.BaseCost;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreThreeMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 3, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = 0.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreSevenMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 7, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = -MilkItem.BaseCost;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreEightMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 8, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = -MilkItem.BaseCost * 2.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreNineMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 9, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = -MilkItem.BaseCost * 2.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreTwelveMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 12, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = -MilkItem.BaseCost * 3.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreFifteenMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 15, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = -MilkItem.BaseCost * 3.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreTwentyMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 20, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = -MilkItem.BaseCost * 5.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreTwentyOneMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(0, 21, 0);

            decimal result = rule.Apply(basketItems);
            decimal expected = -MilkItem.BaseCost * 5.0m;
            Assert.AreEqual(expected, result);
        }
    }
}
