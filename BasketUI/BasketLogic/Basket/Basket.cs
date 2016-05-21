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
        private IList<IRule> _rules;

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

        public decimal Total
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

        private decimal CalculateTotal()
        {
            decimal total = 0m;
            foreach(BasketItem item in _basketItems)
            {
                total += item.Cost;
            }
            total += _rulesEngine.ApplyRules(_basketItems, _rules);
            return total;
        }

        #endregion
    }
}
