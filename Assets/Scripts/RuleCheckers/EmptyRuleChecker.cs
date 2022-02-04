using System.Collections.Generic;
using RuleCheckers.Base;
using Shapes.Base;

namespace RuleCheckers
{
    public class EmptyRuleChecker : IRuleChecker
    {
        public bool CheckRules(IReadOnlyList<ShapeBase> shapes)
        {
            return true;
        }
    }
}