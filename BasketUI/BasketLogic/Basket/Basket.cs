using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasketLogic.BasketItems;
using BasketLogic.Rules;

namespace BasketLogic.Basket
{
    public class Basket : IBasket
    {
        #region Fields
        
        private List<BasketItem> _basketItems;
        private IRulesEngine _rulesEngine;

        #endregion

        #region Constructors

        public Basket()
        {
            _basketItems = new List<BasketItem>();
            _rulesEngine = new RulesEngine();
        }

        public Basket(IRulesEngine rulesEngine)
        {
            _basketItems = new List<BasketItem>();
            _rulesEngine = rulesEngine;
        }

        #endregion

        #region Interface

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
