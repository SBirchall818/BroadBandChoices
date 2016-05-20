using BasketLogic.Basket;
using BasketLogic.BasketItems;
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
            basket.AddItem(new BreadItem());
        }
    }
}
