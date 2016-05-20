using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketLogic.BasketItems;
using System.Collections.Generic;

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

            float result = rule.Apply(basketItems);
            Assert.AreEqual(0.0f, result);
        }
    }
}
