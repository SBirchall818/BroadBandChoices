using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogic.BasketItems
{
    public class MilkItem: BasketItem
    {
        public override decimal Cost
        {
            get
            {
                return 1.15m;
            }
        }
    }
}
