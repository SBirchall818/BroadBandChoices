using System.Collections.Generic;
using BasketLogic.BasketItems;

namespace BasketLogic.Rules
{
    public class EveryFourthMilkFree : IRule
    {
        #region Interface

        public decimal CalculateAdjustment(IList<BasketItem> basketItems)
        {
            decimal adjustment = 0.0m;

            int milks = 0;

            foreach(BasketItem item in basketItems)
            {
                if(item is MilkItem)
                {
                    milks++;
                }
            }

            int numberOfMilkDeductions = milks / 4;

            adjustment = -MilkItem.BaseCost * (decimal)numberOfMilkDeductions;

            return adjustment;
        }

        #endregion
    }
}
