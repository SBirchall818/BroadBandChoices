using BasketLogic.BasketItems;
using System.Collections.Generic;

namespace BasketLogic.Rules
{
    public interface IRulesEngine
    {
        decimal ApplyRules(List<BasketItem> basketItems, IList<IRule> rules);
    }
}
