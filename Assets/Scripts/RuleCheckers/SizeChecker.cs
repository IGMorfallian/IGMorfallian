using System.Collections.Generic;
using RuleCheckers.Base;
using Shapes.Base;

namespace RuleCheckers
{
    public class SizeChecker : IRuleChecker
    {
        public bool CheckRules(IReadOnlyList<ShapeBase> shapes)
        {
            var firstSize = 0;
            for (var index = 0; index < shapes.Count; index++)
            {
                var shape = shapes[index];
                if (index == 0)
                {
                    firstSize = shape.SizeOfShape;
                    continue;
                }

                if (firstSize != shape.SizeOfShape)
                {
                    return false;
                }
            
            }

            return true;
        }
    }
}