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

            float result = rule.Apply(basketItems);
            Assert.AreEqual(0.0f, result);
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

            float result = rule.Apply(basketItems);
            float expected = -(breadItem.Cost / 2.0f);
            Assert.AreEqual(expected, result);
        }
    }
}
