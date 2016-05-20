using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketLogic.BasketItems;

namespace BasketLogic.Basket
{
    public class Basket : IBasket
    {
        #region Fields
        
        private List<BasketItem> _basketItems;

        #endregion

        #region Constructors

        public Basket()
        {
            _basketItems = new List<BasketItem>();
        }

        #endregion

        #region Interface Members

        public float Total
        {
            get
            {
                return CalculateTotal();
            }
        }

        public void AddItem(BasketItem basketItem)
        {
            _basketItems.Add(basketItem);
        }

        #endregion

        #region Private

        private float CalculateTotal()
        {
            float total = 0f;
            foreach(BasketItem item in _basketItems)
            {
                total += item.Cost;
            }
            return total;
        }

        #endregion
    }
}
