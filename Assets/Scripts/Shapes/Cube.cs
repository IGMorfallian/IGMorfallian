using Mechanics.MainMechanic;
using Shapes.Base;
using Utils;

namespace Shapes
{
    public class Cube: ShapeBase
    {
        private SizeCube _sizeCube;
        public override int TypeId => TypeOf<Cube>.TypeId;
        public override int SizeOfShape
        {
            get
            {
                if (_sizeCube is null)
                {
                    _sizeCube = GetComponent<SizeCube>();
                }

                return _sizeCube.SizeOfShape;
            }
        }
    }
}