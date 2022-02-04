using System;
using System.Collections.Generic;
using Mechanics.Base;
using RuleCheckers;
using RuleCheckers.Base;
using Shapes;
using Shapes.Base;

namespace Mechanics.MainMechanic
{
    public class MainMechanic : MechanicBase
    {
        public event Action OnAddPoint;
        protected override ShapeSequence CreateSequence() => new ShapeSequence()
            .Add<Cube>()
            .Add<Sphere>();

        protected override IRuleChecker CreateRuleChecker() => new SizeChecker();

        public override void Execute(IReadOnlyList<ShapeBase> shapes)
        {
            var sphere = shapes[0];
            sphere.InActive = false;

            var cube = shapes[1];
            cube.transform.position = sphere.transform.position;
            cube.InActive = false;
            OnAddPoint?.Invoke();
        }
    }
}