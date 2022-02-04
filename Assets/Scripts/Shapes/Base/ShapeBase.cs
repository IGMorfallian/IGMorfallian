using UnityEngine;

namespace Shapes.Base
{
    public abstract class ShapeBase : MonoBehaviour
    {
        public abstract int TypeId { get; }
        public abstract int SizeOfShape { get;  }
        public bool InActive { get; set; } = true;
        private Color _oldColor;
        private bool _checkChangeColor = false;

        public void Select(Renderer renderer)
        {
            if (_checkChangeColor == false)
            {
                _oldColor = renderer.material.GetColor("_Color");
                renderer.material.SetColor("_Color", Color.red);
            }
            _checkChangeColor = true;
        }

        public void Deselect(Renderer renderer)
        {
            renderer.material.SetColor("_Color", _oldColor);
            _checkChangeColor = false;
        }
    
    }
}
