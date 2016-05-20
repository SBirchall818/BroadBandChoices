using BasketLogic.Basket;
using BasketLogic.BasketItems;
using BasketLogic.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace BasketLogicTests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void ShouldBeAbleToAddButterItemToBasket()
        {
            Basket basket = new Basket();
            basket.AddItem(new ButterItem());
        }

        [TestMethod]
        public void ShouldBeAbleToAddMilkItemToBasket()
        {
            Basket basket = new Basket();
            basket.AddItem(new MilkItem());
        }

        [TestMethod]
        public void ShouldBeAbleToAddBreadItemToBasket()
        {
            Basket basket = new Basket();
            basket.AddItem(new BreadItem());
        }

        [TestMethod]
        public void CallingTotalShouldCalculateTotal()
        {
            Basket basket = new Basket();
            float result = basket.Total;
            Assert.AreEqual(0f, result);
        }

        [TestMethod]
        public void TotalOfButterMilkBreadShouldBeAccurate()
        {
            Basket basket = new Basket();
            basket.AddItem(new ButterItem());
            basket.AddItem(new MilkItem());
            basket.AddItem(new BreadItem());

            float result = basket.Total;
            Assert.AreEqual(2.95f, result);
        }

        [TestMethod]
        public void BasketCanBeCreatedWithGenericRulesEngine()
        {
            Mock<IRulesEngine> mockRulesEngine = new Mock<IRulesEngine>();
            mockRulesEngine.Setup(m => m.ApplyRules(It.IsAny<IList<IRule>>())).Returns(0.0f);
            Basket basket = new Basket(mockRulesEngine.Object);
        }

        [TestMethod]
        public void AppliedRulesModifyTotals()
        {
            Mock<IRulesEngine> mockRulesEngine = new Mock<IRulesEngine>();
            mockRulesEngine.Setup(m => m.ApplyRules(It.IsAny<IList<IRule>>())).Returns(0.0f);
            Basket basket = new Basket(mockRulesEngine.Object);

            mockRulesEngine.Verify(m => m.ApplyRules(It.IsAny<IList<IRule>>()));
        }
    }
}
