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

        [TestMethod]
        public void ClickingButterButtonShouldUpdateTheTotal()
        {
            Mock<IBasket> mockBasket = new Mock<IBasket>();
            mockBasket.SetupGet(m => m.Total).Returns(1.15f);
            BasketForm basketForm = new BasketForm(mockBasket.Object);
            basketForm.ButterButton_Click(null, null);

            mockBasket.VerifyGet(m => m.Total);
            Assert.AreEqual("£1.15", basketForm.TotalTextBox.Text);
        }

        [TestMethod]
        public void ClickingMilkButtonShouldAddMilkItemToBasket()
        {
            Mock<IBasket> mockBasket = new Mock<IBasket>();
            mockBasket.Setup(m => m.AddItem(It.IsAny<BasketItem>()));
            BasketForm basketForm = new BasketForm(mockBasket.Object);
            basketForm.MilkButton_Click(null, null);
            mockBasket.Verify(m => m.AddItem(It.IsAny<MilkItem>()));
        }

        [TestMethod]
        public void ClickingMilkButtonShouldUpdateTheTotal()
        {
            Mock<IBasket> mockBasket = new Mock<IBasket>();
            mockBasket.SetupGet(m => m.Total).Returns(0.8f);
            BasketForm basketForm = new BasketForm(mockBasket.Object);
            basketForm.MilkButton_Click(null, null);

            mockBasket.VerifyGet(m => m.Total);
            Assert.AreEqual("£0.80", basketForm.TotalTextBox.Text);
        }

        [TestMethod]
        public void ClickingBreadButtonShouldAddBreadItemToBasket()
        {
            Mock<IBasket> mockBasket = new Mock<IBasket>();
            mockBasket.Setup(m => m.AddItem(It.IsAny<BasketItem>()));
            BasketForm basketForm = new BasketForm(mockBasket.Object);
            basketForm.BreadButton_Click(null, null);
            mockBasket.Verify(m => m.AddItem(It.IsAny<BreadItem>()));
        }
    }
}
