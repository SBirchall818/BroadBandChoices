using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketLogic.BasketItems;

namespace BasketLogic.Rules
{
    public class EveryFourthMilkFree : IRule
    {
        #region Interface

        public decimal Apply(IList<BasketItem> basketItems)
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

            adjustment = -(new MilkItem()).Cost * (decimal)numberOfMilkDeductions;

            return adjustment;
        }

        #endregion
    }
}
