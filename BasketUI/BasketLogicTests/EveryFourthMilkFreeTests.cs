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

            float result = rule.Apply(basketItems);
            Assert.AreEqual(0.0f, result);
        }

        [TestMethod]
        public void AppliesIfThereAreFourMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            MilkItem milkItemB = new MilkItem();
            MilkItem milkItemC = new MilkItem();
            MilkItem milkItemD = new MilkItem();
            basketItems.Add(milkItemA);
            basketItems.Add(milkItemB);
            basketItems.Add(milkItemC);
            basketItems.Add(milkItemD);

            float result = rule.Apply(basketItems);
            float expected = -milkItemD.Cost;
            Assert.AreEqual(expected, result);
        }
    }
}
