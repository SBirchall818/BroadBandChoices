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
            Mock<IRulesEngine> mockRulesEngine = new Mock<IRulesEngine>();
            mockRulesEngine.Setup(m => m.ApplyRules(It.IsAny<List<BasketItem>>(), It.IsAny<IList<IRule>>())).Returns(0.0m);
            Basket basket = new Basket(mockRulesEngine.Object);
            decimal result = basket.Total;
            Assert.AreEqual(0m, result);
        }

        [TestMethod]
        public void TotalOfButterMilkBreadShouldBeAccurate()
        {
            Mock<IRulesEngine> mockRulesEngine = new Mock<IRulesEngine>();
            ButterItem butterItem = new ButterItem();
            MilkItem milkItem = new MilkItem();
            BreadItem breadItem = new BreadItem();
            mockRulesEngine.Setup(m => m.ApplyRules(It.IsAny<List<BasketItem>>(), It.IsAny<IList<IRule>>())).Returns(0.0m);
            Basket basket = new Basket(mockRulesEngine.Object);
            basket.AddItem(butterItem);
            basket.AddItem(milkItem);
            basket.AddItem(breadItem);

            decimal result = basket.Total;
            Assert.AreEqual(butterItem.Cost + milkItem.Cost + breadItem.Cost, result);
        }

        [TestMethod]
        public void BasketCanBeCreatedWithGenericRulesEngine()
        {
            Mock<IRulesEngine> mockRulesEngine = new Mock<IRulesEngine>();
            mockRulesEngine.Setup(m => m.ApplyRules(It.IsAny<List<BasketItem>>(), It.IsAny<IList<IRule>>())).Returns(0.0m);
            Basket basket = new Basket(mockRulesEngine.Object);
        }

        [TestMethod]
        public void AppliedRulesModifyTotals()
        {
            decimal deduction = 1.0m;
            Mock<IRulesEngine> mockRulesEngine = new Mock<IRulesEngine>();
            mockRulesEngine.Setup(m => m.ApplyRules(It.IsAny<List<BasketItem>>(), It.IsAny<IList<IRule>>())).Returns(-deduction);
            Basket basket = new Basket(mockRulesEngine.Object);
            MilkItem milkItem = new MilkItem();
            basket.AddItem(milkItem);

            decimal total = basket.Total;
            Assert.AreEqual(milkItem.Cost - deduction, total);
            mockRulesEngine.Verify(m => m.ApplyRules(It.IsAny<List<BasketItem>>(), It.IsAny<IList<IRule>>()));
        }
    }
}
