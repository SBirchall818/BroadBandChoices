using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketUI;
using Moq;
using BasketLogic.Basket;
using BasketLogic.BasketItems;

namespace BasketUITests
{
    [TestClass]
    public class BehaviorTests
    {
        [TestMethod]
        public void ClickingButterButtonShouldAddButterItemToBasket()
        {
            Mock<IBasket> mockBasket = new Mock<IBasket>();
            mockBasket.Setup(m => m.AddItem(It.IsAny<BasketItem>()));
            BasketForm basketForm = new BasketForm(mockBasket.Object);
            basketForm.ButterButton_Click(null, null);
            mockBasket.Verify(m => m.AddItem(It.IsAny<ButterItem>()));
        }
    }
}
