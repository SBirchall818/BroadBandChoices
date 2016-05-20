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
            mockRulesEngine.Setup(m => m.ApplyRules(It.IsAny<IList<IRule>>())).Returns(0.0f);
        }

        [TestMethod]
        public void RulesEngineWillApplyAllRules()
        {
            RulesEngine rulesEngine = new RulesEngine();
            Mock<IRule> mockRuleA = new Mock<IRule>();
            mockRuleA.Setup(m => m.Apply(It.IsAny<List<BasketItem>()));
        }
    }
}