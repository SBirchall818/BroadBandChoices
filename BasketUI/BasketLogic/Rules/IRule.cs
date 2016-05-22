using BasketLogic.BasketItems;
using System.Collections.Generic;

namespace BasketLogic.Rules
{
    public interface IRule
    {
        decimal CalculateAdjustment(IList<BasketItem> basketItems);
    }
}
