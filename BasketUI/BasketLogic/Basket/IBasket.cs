using BasketLogic.BasketItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogic.Basket
{
    public interface IBasket
    {
        decimal Total { get; }
        void AddItem(BasketItem basketItem);
    }
}
