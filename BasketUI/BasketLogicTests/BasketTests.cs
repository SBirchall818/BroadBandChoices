using BasketLogic.Basket;
using BasketLogic.BasketItems;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
