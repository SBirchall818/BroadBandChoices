using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketUI;
using Moq;
using BasketLogic.Basket;

namespace BasketUITests
{
    [TestClass]
    public class BehaviorTests
    {
        [TestMethod]
        public void ClickingButterButtonShouldAddItemToBasket()
        {
            Mock<IBasket> mockBasket = new Mock<IBasket>();
            BasketForm basketForm = new BasketForm(mockBasket.Object);
            basketForm.ButterButton_Click(null, null);
        }
    }
}
