using System.Collections.Generic;
using Mechanics.Base;
using Mechanics.MainMechanic;
using RuleCheckers;
using RuleCheckers.Base;
using Shapes;
using Shapes.Base;
using UnityEngine;

namespace Mechanics.TriangleMechanic
{
    public class TriangleMechanic : MechanicBase
    {
        [SerializeField] private Energy energy;
        protected override IRuleChecker CreateRuleChecker() => new EnergyAndCubeSizeChecker(energy);

        public override void Execute(IReadOnlyList<ShapeBase> shapes)
        {
            var sizeCube = shapes[1].GetComponent<SizeCube>();
            sizeCube.SizeOfShape--;
            sizeCube.SetScaleCube(sizeCube.SizeOfShape);
            Destroy(shapes[0].gameObject);
            energy.DecrementEnergy();
        }

        protected override ShapeSequence CreateSequence() => new ShapeSequence()
            .Add<Triangle>()
            .Add<Cube>();
    }
}