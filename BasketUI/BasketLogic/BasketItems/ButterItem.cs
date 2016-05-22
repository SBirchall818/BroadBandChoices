using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogic.BasketItems
{
    public class ButterItem: BasketItem
    {
        public static decimal BaseCost = 0.8m;

        public override decimal Cost
        {
            get
            {
                return BaseCost;
            }
        }
    }
}
