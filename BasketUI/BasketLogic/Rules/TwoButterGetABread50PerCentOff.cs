using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketLogic.BasketItems;

namespace BasketLogic.Rules
{
    public class TwoButterGetABread50PerCentOff : IRule
    {

        #region Interface

        public float Apply(IList<BasketItem> basketItems)
        {
            float adjustment = 0.0f;



            return adjustment;
        }

        #endregion
    }
}
