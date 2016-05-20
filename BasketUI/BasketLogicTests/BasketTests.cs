using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasketLogicTests
{
    [TestClass]
    public class BasketTests
    {
        [TestMethod]
        public void ShouldBeAbleToAddBreadItemToBasket()
        {
            Basket basket = new Basket();
            Assert.IsNotNull(basket.Items)
        }
    }
}
