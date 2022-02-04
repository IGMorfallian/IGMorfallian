using System.Collections.Generic;
using Mechanics.TriangleMechanic;
using RuleCheckers.Base;
using Shapes.Base;

namespace RuleCheckers
{
    public class EnergyAndCubeSizeChecker : IRuleChecker
    {
        private readonly Energy _energy;

        public EnergyAndCubeSizeChecker(Energy energy)
        {
            _energy = energy;
        }
        public bool CheckRules(IReadOnlyList<ShapeBase> shapes)
        {
            if (shapes[1].SizeOfShape > 1 && _energy.CountEnergy > 0)
            {
                return true;
            }

            return false;
        }
    }
}