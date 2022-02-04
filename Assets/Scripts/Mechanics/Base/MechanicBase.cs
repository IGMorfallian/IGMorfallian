using System.Collections.Generic;
using RuleCheckers;
using RuleCheckers.Base;
using Shapes.Base;
using UnityEngine;

namespace Mechanics.Base
{
    public abstract class MechanicBase : MonoBehaviour
    {
        private ShapeSequence _shapeSequence;
        private IRuleChecker _ruleChecker;

        public abstract void Execute(IReadOnlyList<ShapeBase> shapes);

        public bool CheckForExecution(IReadOnlyList<ShapeBase> shapes)
        {
            return _shapeSequence.CheckSequence(shapes) &&
                   _ruleChecker.CheckRules(shapes);
        }

        protected abstract ShapeSequence CreateSequence();
        protected virtual IRuleChecker CreateRuleChecker() => new EmptyRuleChecker();

        private void Awake()
        {
            _shapeSequence = CreateSequence();
            _ruleChecker = CreateRuleChecker();
        }
    }
}