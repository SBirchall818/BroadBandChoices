using System.Collections.Generic;

namespace BasketLogic.Rules
{
    public interface IRulesEngine
    {
        float ApplyRules(IList<IRule> rules);
    }
}
