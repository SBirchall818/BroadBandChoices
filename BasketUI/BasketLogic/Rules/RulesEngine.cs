using System;
using System.Collections.Generic;

namespace BasketLogic.Rules
{
    public class RulesEngine: IRulesEngine
    {
        #region Constructors

        public RulesEngine()
        {
        }

        #endregion

        #region Interface

        public float ApplyRules(IList<IRule> rules)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
