﻿using System;
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
    }
}
