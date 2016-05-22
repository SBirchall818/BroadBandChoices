using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BasketLogic.BasketItems;
using BasketLogic.Rules;

namespace BasketLogicTests
{
    [TestClass]
    public class TwoButterGetABread50PerCentOffTests
    {
        [TestMethod]
        public void DoesNotApplyIfListIsEmpty()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();

            decimal result = rule.CalculateAdjustment(basketItems);
            Assert.AreEqual(0.0m, result);
        }

        [TestMethod]
        public void AppliesIfTwoButterAndBreadInBasket()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(
                butters: 2,
                milks: 0,
                breads: 1);

            decimal result = rule.CalculateAdjustment(basketItems);
            decimal expected = -(BreadItem.BaseCost / 2.0m);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void AppliesIfFourButterAndSingleBreadInBasket()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(
                butters: 4,
                milks: 0,
                breads: 1);

            decimal result = rule.CalculateAdjustment(basketItems);
            decimal expected = -(BreadItem.BaseCost / 2.0m);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfFourButterAndTwoBreadInBasket()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(
                butters: 4,
                milks: 0,
                breads: 2);

            decimal result = rule.CalculateAdjustment(basketItems);
            decimal expected = -BreadItem.BaseCost;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfFourButterAndThreeBreadInBasket()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(
                butters: 4,
                milks: 0,
                breads: 3);

            decimal result = rule.CalculateAdjustment(basketItems);
            decimal expected = -BreadItem.BaseCost;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfTwoButterAndBreadInBasketMilkHasNoEffect()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(
                butters: 2,
                milks: 4,
                breads: 1);

            decimal result = rule.CalculateAdjustment(basketItems);
            decimal expected = -(BreadItem.BaseCost / 2.0m);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void AppliesIfFourButterAndSingleBreadInBasketMilkHasNoEffect()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(
                butters: 4,
                milks: 4,
                breads: 1);

            decimal result = rule.CalculateAdjustment(basketItems);
            decimal expected = -(BreadItem.BaseCost / 2.0m);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfFourButterAndTwoBreadInBasketMilkHasNoEffect()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(
                butters: 4,
                milks: 4,
                breads: 2);

            decimal result = rule.CalculateAdjustment(basketItems);
            decimal expected = -BreadItem.BaseCost;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfFourButterAndThreeBreadInBasketMilkHasNoEffect()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = BasketItemHelper.CreateBasketItems(
                butters: 4,
                milks: 4,
                breads: 3);

            decimal result = rule.CalculateAdjustment(basketItems);
            decimal expected = -BreadItem.BaseCost;
            Assert.AreEqual(expected, result);
        }
    }
}
