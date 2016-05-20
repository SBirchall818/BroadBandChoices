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
        #region Fields

        private BasketForm _basketForm;

        #endregion

        [TestInitialize]
        public void BeforeAllTests()
        {
            _basketForm = new BasketForm();
        }

        [TestMethod]
        public void BasketUICanBeInitializedWithABasket()
        {
            Mock<IBasket> mockBasket = new Mock<IBasket>();
            BasketForm basketForm = new BasketForm(mockBasket.Object);
        }

        [TestMethod]
        public void BasketUIShouldHaveAButterButton()
        {
            Assert.IsNotNull(_basketForm.ButterButton);
        }

        [TestMethod]
        public void BasketUIShouldHaveAMilkButton()
        {
            Assert.IsNotNull(_basketForm.MilkButton);
        }

        [TestMethod]
        public void BasketUIShouldHaveABreadButton()
        {
            Assert.IsNotNull(_basketForm.BreadButton);
        }

        [TestMethod]
        public void BasketUIShouldDisplayButterCost()
        {
            Assert.IsNotNull(_basketForm.ButterTextBox);
        }

        [TestMethod]
        public void ButterCostShouldNotBeEditable()
        {
            Assert.IsTrue(_basketForm.ButterTextBox.ReadOnly);
        }

        [TestMethod]
        public void ButterCostShouldHaveTheCostHardCoded()
        {
            Assert.AreEqual("£0.80", _basketForm.ButterTextBox.Text);
        }

        [TestMethod]
        public void BasketUIShouldDisplayMilkCost()
        {
            Assert.IsNotNull(_basketForm.MilkTextBox);
        }

        [TestMethod]
        public void MilkCostShouldNotBeEditable()
        {
            Assert.IsTrue(_basketForm.MilkTextBox.ReadOnly);
        }

        [TestMethod]
        public void MilkCostShouldHaveTheCostHardCoded()
        {
            Assert.AreEqual("£1.15", _basketForm.MilkTextBox.Text);
        }

        [TestMethod]
        public void BasketUIShouldDisplayBreadCost()
        {
            Assert.IsNotNull(_basketForm.BreadTextBox);
        }

        [TestMethod]
        public void BreadCostShouldNotBeEditable()
        {
            Assert.IsTrue(_basketForm.BreadTextBox.ReadOnly);
        }

        [TestMethod]
        public void BreadCostShouldHaveTheCostHardCoded()
        {
            Assert.AreEqual("£1.00", _basketForm.BreadTextBox.Text);
        }

        [TestMethod]
        public void BasketUIShouldDisplayOffers()
        {
            Assert.IsNotNull(_basketForm.OffersTextBox);
        }

        [TestMethod]
        public void OffersShouldNotBeEditable()
        {
            Assert.IsTrue(_basketForm.OffersTextBox.ReadOnly);
        }

        [TestMethod]
        public void BasketUIShouldDisplayTotalLabel()
        {
            Assert.IsNotNull(_basketForm.TotalLabel);
        }

        [TestMethod]
        public void BasketUIShouldDisplayTotalTextBox()
        {
            Assert.IsNotNull(_basketForm.TotalTextBox);
        }

        [TestMethod]
        public void TotalTextBoxShouldBeNonEditable()
        {
            Assert.IsTrue(_basketForm.TotalTextBox.ReadOnly);
        }

        [TestMethod]
        public void TotalTextBoxShouldHaveInitialDisplayOfZeroPounds()
        {
            Assert.AreEqual("£0.00", _basketForm.TotalTextBox.Text);
        }
    }
}
