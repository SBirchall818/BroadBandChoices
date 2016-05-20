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
    }
}
