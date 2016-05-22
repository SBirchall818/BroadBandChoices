using BasketLogic.BasketItems;
using System;
using System.Collections.Generic;

namespace BasketLogic.Rules
{
    public class RulesEngine: IRulesEngine
    {
        #region Constructors

        public RulesEngine()
        {
        }

        #endregion

        #region Interface

        public decimal CalculateAdjustmentsFromRules(List<BasketItem> basketItems, IList<IRule> rules)
        {
            decimal adjustments = 0.0m;
            foreach(IRule rule in rules)
            {
                adjustments += rule.CalculateAdjustment(basketItems);
            }
            return adjustments;
        }

        #endregion
    }
}
