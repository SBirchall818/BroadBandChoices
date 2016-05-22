using BasketLogic.Basket;
using BasketLogic.BasketItems;
using System.Collections.Generic;

namespace BasketLogicTests
{
    public static class BasketItemHelper
    {
        public static void LoadBasketItems(ref Basket basket, int butters, int milks, int breads)
        {

            for (int i = 0; i < butters; i++)
            {
                basket.AddItem(new ButterItem());
            }

            for (int i = 0; i < milks; i++)
            {
                basket.AddItem(new MilkItem());
            }

            for (int i = 0; i < breads; i++)
            {
                basket.AddItem(new BreadItem());
            }
        }

        public static List<BasketItem> CreateBasketItems(int butters, int milks, int breads)
        {
            List<BasketItem> basketItems = new List<BasketItem>();

            for (int i = 0; i < butters; i++)
            {
                basketItems.Add(new ButterItem());
            }

            for (int i = 0; i < milks; i++)
            {
                basketItems.Add(new MilkItem());
            }

            for (int i = 0; i < breads; i++)
            {
                basketItems.Add(new BreadItem());
            }

            return basketItems;
        }
    }
}
