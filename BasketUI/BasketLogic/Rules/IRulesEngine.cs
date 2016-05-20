using BasketLogic.BasketItems;
using System.Collections.Generic;

namespace BasketLogic.Rules
{
    public interface IRulesEngine
    {
        float ApplyRules(List<BasketItem> basketItems, IList<IRule> rules);
    }
}
