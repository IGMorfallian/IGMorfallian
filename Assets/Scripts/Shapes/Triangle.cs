using Shapes.Base;
using Utils;

namespace Shapes
{
    public class Triangle: ShapeBase
    {
        private int _defaultSize;
        public override int TypeId => TypeOf<Triangle>.TypeId;
        public override int SizeOfShape => _defaultSize;
    }
}
