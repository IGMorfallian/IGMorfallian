using Mechanics.MainMechanic;
using Shapes.Base;
using Utils;

namespace Shapes
{
    public class Sphere : ShapeBase
    {
        private SizeSphere _sizeSphere;

        public override int TypeId => TypeOf<Sphere>.TypeId;

        public override int SizeOfShape
        {
            get
            {
                if (_sizeSphere is null)
                {
                    _sizeSphere = GetComponent<SizeSphere>();
                }

                return _sizeSphere.SizeOfShape;
            }
        }
    }
}