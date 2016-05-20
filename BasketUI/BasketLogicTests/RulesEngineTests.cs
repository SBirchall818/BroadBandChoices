using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BasketLogicTests
{
    [TestClass]
    public class RulesEngineTest
    {
        [TestMethod]
        public void RulesEngineHasApplyRulesMethod()
        {
            Mock<IRulesEngine> mockRulesEngine = new Mock<IRulesEngine>();
        }
    }
}