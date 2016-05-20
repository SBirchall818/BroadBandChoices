using System.Collections.Generic;
using BasketLogic.BasketItems;

namespace BasketLogic.Rules
{
    public class TwoButterGetABread50PerCentOff : IRule
    {

        #region Interface

        public float Apply(IList<BasketItem> basketItems)
        {
            float adjustment = 0.0f;

            int butters = 0;
            int breads = 0;

            foreach(BasketItem item in basketItems)
            {
                if(item is BreadItem)
                {
                    breads++;
                }
                else if(item is ButterItem)
                {
                    butters++;
                }
            }

            int maximumBreadsAppliedTo = butters / 2;

            int breadsAppliedTo = 0;
            if(0 <= breads && breads < maximumBreadsAppliedTo)
            {
                breadsAppliedTo = breads;
            }
            else if(breads >= maximumBreadsAppliedTo)
            {
                breadsAppliedTo = maximumBreadsAppliedTo;
            }

            adjustment = -(new BreadItem()).Cost / 2.0f * (float)breadsAppliedTo;

            return adjustment;
        }

        #endregion
    }
}
