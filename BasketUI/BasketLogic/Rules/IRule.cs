using BasketLogic.BasketItems;
using System.Collections.Generic;

namespace BasketLogic.Rules
{
    public interface IRule
    {
        float Apply(IList<BasketItem> basketItems);
    }
}
