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

        public decimal ApplyRules(List<BasketItem> basketItem, IList<IRule> rules)
        {
            decimal adjustments = 0.0m;
            foreach(IRule rule in rules)
            {
                adjustments += rule.CalculateAdjustment(basketItem);
            }
            return adjustments;
        }

        #endregion
    }
}
