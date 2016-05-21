﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using BasketLogic.BasketItems;
using System.Collections.Generic;
using BasketLogic.Rules;

namespace BasketLogicTests
{
    [TestClass]
    public class EveryFourthMilkFreeTests
    {
        [TestMethod]
        public void DoesNotApplyIfListIsEmpty()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();

            decimal result = rule.Apply(basketItems);
            Assert.AreEqual(0.0m, result);
        }

        [TestMethod]
        public void AppliesIfThereAreFourMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            MilkItem milkItemB = new MilkItem();
            MilkItem milkItemC = new MilkItem();
            MilkItem milkItemD = new MilkItem();
            basketItems.Add(milkItemA);
            basketItems.Add(milkItemB);
            basketItems.Add(milkItemC);
            basketItems.Add(milkItemD);

            decimal result = rule.Apply(basketItems);
            decimal expected = -milkItemD.Cost;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreThreeMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            MilkItem milkItemB = new MilkItem();
            MilkItem milkItemC = new MilkItem();
            basketItems.Add(milkItemA);
            basketItems.Add(milkItemB);
            basketItems.Add(milkItemC);

            decimal result = rule.Apply(basketItems);
            decimal expected = 0.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreSevenMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            basketItems.Add(milkItemA);
            for(int i=0; i<6; i++)
            {
                basketItems.Add(new MilkItem());
            }

            decimal result = rule.Apply(basketItems);
            decimal expected = -milkItemA.Cost;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreEightMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            basketItems.Add(milkItemA);
            for (int i = 0; i < 7; i++)
            {
                basketItems.Add(new MilkItem());
            }

            decimal result = rule.Apply(basketItems);
            decimal expected = -milkItemA.Cost * 2.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreNineMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            basketItems.Add(milkItemA);
            for (int i = 0; i < 8; i++)
            {
                basketItems.Add(new MilkItem());
            }

            decimal result = rule.Apply(basketItems);
            decimal expected = -milkItemA.Cost * 2.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreTwelveMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            basketItems.Add(milkItemA);
            for (int i = 0; i < 11; i++)
            {
                basketItems.Add(new MilkItem());
            }

            decimal result = rule.Apply(basketItems);
            decimal expected = -milkItemA.Cost * 3.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreFifteenMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            basketItems.Add(milkItemA);
            for (int i = 0; i < 14; i++)
            {
                basketItems.Add(new MilkItem());
            }

            decimal result = rule.Apply(basketItems);
            decimal expected = -milkItemA.Cost * 3.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreTwentyMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            basketItems.Add(milkItemA);
            for (int i = 0; i < 19; i++)
            {
                basketItems.Add(new MilkItem());
            }

            decimal result = rule.Apply(basketItems);
            decimal expected = -milkItemA.Cost * 5.0m;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AppliesIfThereAreTwentyOneMilks()
        {
            EveryFourthMilkFree rule = new EveryFourthMilkFree();
            List<BasketItem> basketItems = new List<BasketItem>();
            MilkItem milkItemA = new MilkItem();
            basketItems.Add(milkItemA);
            for (int i = 0; i < 20; i++)
            {
                basketItems.Add(new MilkItem());
            }

            decimal result = rule.Apply(basketItems);
            decimal expected = -milkItemA.Cost * 5.0m;
            Assert.AreEqual(expected, result);
        }
    }
}
