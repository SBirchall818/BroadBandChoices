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

        public float ApplyRules(List<BasketItem> basketItem, IList<IRule> rules)
        {
            float adjustments = 0.0f;
            foreach(IRule rule in rules)
            {
                adjustments += rule.Apply(basketItem);
            }
            return adjustments;
        }

        #endregion
    }
}
