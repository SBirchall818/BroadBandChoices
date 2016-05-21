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

            decimal result = rule.Apply(basketItems);
            Assert.AreEqual(0.0m, result);
        }

        [TestMethod]
        public void AppliesIfTwoButterAndBreadInBasket()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();
            ButterItem butterItemA = new ButterItem();
            ButterItem butterItemB = new ButterItem();
            BreadItem breadItem = new BreadItem();
            basketItems.Add(butterItemA);
            basketItems.Add(butterItemB);
            basketItems.Add(breadItem);

            decimal result = rule.Apply(basketItems);
            decimal expected = -(breadItem.Cost / 2.0m);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void AppliesIfFourButterAndSingleBreadInBasket()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();
            ButterItem butterItemA = new ButterItem();
            ButterItem butterItemB = new ButterItem();
            ButterItem butterItemC = new ButterItem();
            ButterItem butterItemD = new ButterItem();
            BreadItem breadItem = new BreadItem();
            basketItems.Add(butterItemA);
            basketItems.Add(butterItemB);
            basketItems.Add(butterItemC);
            basketItems.Add(butterItemD);
            basketItems.Add(breadItem);

            decimal result = rule.Apply(basketItems);
            decimal expected = -(breadItem.Cost / 2.0m);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfFourButterAndTwoBreadInBasket()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();
            ButterItem butterItemA = new ButterItem();
            ButterItem butterItemB = new ButterItem();
            ButterItem butterItemC = new ButterItem();
            ButterItem butterItemD = new ButterItem();
            BreadItem breadItemA = new BreadItem();
            BreadItem breadItemB = new BreadItem();
            BreadItem breadItemC = new BreadItem();
            basketItems.Add(butterItemA);
            basketItems.Add(butterItemB);
            basketItems.Add(butterItemC);
            basketItems.Add(butterItemD);
            basketItems.Add(breadItemA);
            basketItems.Add(breadItemB);
            basketItems.Add(breadItemC);

            decimal result = rule.Apply(basketItems);
            decimal expected = -((breadItemA.Cost + breadItemB.Cost) / 2.0m);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfFourButterAndThreeBreadInBasket()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();
            ButterItem butterItemA = new ButterItem();
            ButterItem butterItemB = new ButterItem();
            ButterItem butterItemC = new ButterItem();
            ButterItem butterItemD = new ButterItem();
            BreadItem breadItemA = new BreadItem();
            BreadItem breadItemB = new BreadItem();
            basketItems.Add(butterItemA);
            basketItems.Add(butterItemB);
            basketItems.Add(butterItemC);
            basketItems.Add(butterItemD);
            basketItems.Add(breadItemA);
            basketItems.Add(breadItemB);

            decimal result = rule.Apply(basketItems);
            decimal expected = -((breadItemA.Cost + breadItemB.Cost) / 2.0m);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfTwoButterAndBreadInBasketMilkHasNoEffect()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();
            ButterItem butterItemA = new ButterItem();
            ButterItem butterItemB = new ButterItem();
            BreadItem breadItem = new BreadItem();
            MilkItem milkItemA = new MilkItem();
            MilkItem milkItemB = new MilkItem();
            MilkItem milkItemC = new MilkItem();
            MilkItem milkItemD = new MilkItem();
            basketItems.Add(milkItemA);
            basketItems.Add(milkItemB);
            basketItems.Add(milkItemC);
            basketItems.Add(milkItemD);

            basketItems.Add(butterItemA);
            basketItems.Add(butterItemB);
            basketItems.Add(breadItem);

            decimal result = rule.Apply(basketItems);
            decimal expected = -(breadItem.Cost / 2.0m);
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void AppliesIfFourButterAndSingleBreadInBasketMilkHasNoEffect()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();
            ButterItem butterItemA = new ButterItem();
            ButterItem butterItemB = new ButterItem();
            ButterItem butterItemC = new ButterItem();
            ButterItem butterItemD = new ButterItem();
            BreadItem breadItem = new BreadItem();
            MilkItem milkItemA = new MilkItem();
            MilkItem milkItemB = new MilkItem();
            MilkItem milkItemC = new MilkItem();
            MilkItem milkItemD = new MilkItem();
            basketItems.Add(milkItemA);
            basketItems.Add(milkItemB);
            basketItems.Add(milkItemC);
            basketItems.Add(milkItemD);
            basketItems.Add(butterItemA);
            basketItems.Add(butterItemB);
            basketItems.Add(butterItemC);
            basketItems.Add(butterItemD);
            basketItems.Add(breadItem);

            decimal result = rule.Apply(basketItems);
            decimal expected = -(breadItem.Cost / 2.0m);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfFourButterAndTwoBreadInBasketMilkHasNoEffect()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();
            ButterItem butterItemA = new ButterItem();
            ButterItem butterItemB = new ButterItem();
            ButterItem butterItemC = new ButterItem();
            ButterItem butterItemD = new ButterItem();
            BreadItem breadItemA = new BreadItem();
            BreadItem breadItemB = new BreadItem();
            BreadItem breadItemC = new BreadItem();
            MilkItem milkItemA = new MilkItem();
            MilkItem milkItemB = new MilkItem();
            MilkItem milkItemC = new MilkItem();
            MilkItem milkItemD = new MilkItem();
            basketItems.Add(milkItemA);
            basketItems.Add(milkItemB);
            basketItems.Add(milkItemC);
            basketItems.Add(milkItemD);
            basketItems.Add(butterItemA);
            basketItems.Add(butterItemB);
            basketItems.Add(butterItemC);
            basketItems.Add(butterItemD);
            basketItems.Add(breadItemA);
            basketItems.Add(breadItemB);
            basketItems.Add(breadItemC);

            decimal result = rule.Apply(basketItems);
            decimal expected = -((breadItemA.Cost + breadItemB.Cost) / 2.0m);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfFourButterAndThreeBreadInBasketMilkHasNoEffect()
        {
            TwoButterGetABread50PerCentOff rule = new TwoButterGetABread50PerCentOff();
            List<BasketItem> basketItems = new List<BasketItem>();
            ButterItem butterItemA = new ButterItem();
            ButterItem butterItemB = new ButterItem();
            ButterItem butterItemC = new ButterItem();
            ButterItem butterItemD = new ButterItem();
            BreadItem breadItemA = new BreadItem();
            BreadItem breadItemB = new BreadItem();
            MilkItem milkItemA = new MilkItem();
            MilkItem milkItemB = new MilkItem();
            MilkItem milkItemC = new MilkItem();
            MilkItem milkItemD = new MilkItem();
            basketItems.Add(milkItemA);
            basketItems.Add(milkItemB);
            basketItems.Add(milkItemC);
            basketItems.Add(milkItemD);
            basketItems.Add(butterItemA);
            basketItems.Add(butterItemB);
            basketItems.Add(butterItemC);
            basketItems.Add(butterItemD);
            basketItems.Add(breadItemA);
            basketItems.Add(breadItemB);

            decimal result = rule.Apply(basketItems);
            decimal expected = -((breadItemA.Cost + breadItemB.Cost) / 2.0m);
            Assert.AreEqual(expected, result);
        }
    }
}
