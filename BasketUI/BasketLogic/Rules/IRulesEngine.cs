using BasketLogic.BasketItems;
using System.Collections.Generic;

namespace BasketLogic.Rules
{
    public interface IRulesEngine
    {
        decimal CalculateAdjustmentsFromRules(List<BasketItem> basketItems, IList<IRule> rules);
    }
}
