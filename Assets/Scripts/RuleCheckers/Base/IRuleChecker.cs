
using System.Collections.Generic;
using Shapes.Base;

namespace RuleCheckers.Base
{
    public interface IRuleChecker
    {
        bool CheckRules(IReadOnlyList<ShapeBase> shapes);
    }
}
