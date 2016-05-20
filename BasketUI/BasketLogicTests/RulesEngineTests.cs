using BasketLogic.BasketItems;
using BasketLogic.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace BasketLogicTests
{
    [TestClass]
    public class RulesEngineTest
    {
        [TestMethod]
        public void RulesEngineHasApplyRulesMethod()
        {
            Mock<IRulesEngine> mockRulesEngine = new Mock<IRulesEngine>();
            mockRulesEngine.Setup(m => m.ApplyRules(It.IsAny<List<BasketItem>>(), It.IsAny<IList<IRule>>())).Returns(0.0f);
        }

        [TestMethod]
        public void RulesEngineWillApplyAllRules()
        {
            RulesEngine rulesEngine = new RulesEngine();
            Mock<IRule> mockRuleA = new Mock<IRule>();
            float deductionA = 1.0f;
            mockRuleA.Setup(m => m.Apply(It.IsAny<List<BasketItem>>())).Returns(-deductionA);

            Mock<IRule> mockRuleB = new Mock<IRule>();
            float deductionB = 0.7f;
            mockRuleB.Setup(m => m.Apply(It.IsAny<List<BasketItem>>())).Returns(-deductionB);

            List<BasketItem> basketItems = new List<BasketItem>();

            List<IRule> rules = new List<IRule>();
            rules.Add(mockRuleA.Object);
            rules.Add(mockRuleB.Object);

            float adjustment = rulesEngine.ApplyRules(basketItems, rules);

            Assert.AreEqual(-deductionA - deductionB, adjustment);

        }
    }
}