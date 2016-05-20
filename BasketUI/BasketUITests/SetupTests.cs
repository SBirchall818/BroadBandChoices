using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketUI;
using Moq;
using BasketLogic.Basket;

namespace BasketUITests
{
    [TestClass]
    public class SetupTests
    {
        [TestMethod]
        public void BasketUICanBeInitializedWithABasket()
        {
            Mock<IBasket> mockBasket = new Mock<IBasket>();
            BasketForm basketForm = new BasketForm(mockBasket.Object);
        }

        [TestMethod]
        public void BasketUIShouldHaveAButterButton()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.ButterButton);
        }

        [TestMethod]
        public void BasketUIShouldHaveAMilkButton()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.MilkButton);
        }
    }
}
