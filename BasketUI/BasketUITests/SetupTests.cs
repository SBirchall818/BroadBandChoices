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

        [TestMethod]
        public void BasketUIShouldHaveABreadButton()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.BreadButton);
        }

        [TestMethod]
        public void BasketUIShouldDisplayButterCost()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.ButterTextBox);
        }

        [TestMethod]
        public void ButterCostShouldNotBeEditable()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsTrue(basketForm.ButterTextBox.ReadOnly);
        }

        [TestMethod]
        public void ButterCostShouldHaveTheCostHardCoded()
        {
            BasketForm basketForm = new BasketForm();
            Assert.AreEqual("£0.80", basketForm.ButterTextBox.Text);
        }

        [TestMethod]
        public void BasketUIShouldDisplayMilkCost()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.MilkTextBox);
        }

        [TestMethod]
        public void MilkCostShouldNotBeEditable()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsTrue(basketForm.MilkTextBox.ReadOnly);
        }

        [TestMethod]
        public void MilkCostShouldHaveTheCostHardCoded()
        {
            BasketForm basketForm = new BasketForm();
            Assert.AreEqual("£1.15", basketForm.MilkTextBox.Text);
        }

        [TestMethod]
        public void BasketUIShouldDisplayBreadCost()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.BreadTextBox);
        }

        [TestMethod]
        public void BreadCostShouldNotBeEditable()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsTrue(basketForm.BreadTextBox.ReadOnly);
        }

        [TestMethod]
        public void BreadCostShouldHaveTheCostHardCoded()
        {
            BasketForm basketForm = new BasketForm();
            Assert.AreEqual("£1.00", basketForm.BreadTextBox.Text);
        }

        [TestMethod]
        public void BasketUIShouldDisplayOffers()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.OffersTextBox);
        }

        [TestMethod]
        public void OffersShouldNotBeEditable()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsTrue(basketForm.OffersTextBox.ReadOnly);
        }

        [TestMethod]
        public void BasketUIShouldDisplayTotalLabel()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.TotalLabel);
        }

        [TestMethod]
        public void BasketUIShouldDisplayTotalTextBox()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsNotNull(basketForm.TotalTextBox);
        }

        [TestMethod]
        public void TotalTextBoxShouldBeNonEditable()
        {
            BasketForm basketForm = new BasketForm();
            Assert.IsTrue(basketForm.TotalTextBox.ReadOnly);
        }

        [TestMethod]
        public void TotalTextBoxShouldHaveInitialDisplayOfZeroPounds()
        {
            BasketForm basketForm = new BasketForm();
            Assert.AreEqual("£0.00", basketForm.TotalTextBox.Text);
        }
    }
}
