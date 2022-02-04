using Mechanics.Base;
using UnityEngine;

namespace Mechanics
{
    public class MechanicsExecutor : MonoBehaviour
    {
        [SerializeField] private MechanicBase[] mechanics;
        [SerializeField] private SelectionHandler _selectionHandler;

        private void OnEnable()
        {
            _selectionHandler.OnShapeSelect += OnShapeSelectHandler;
        }

        private void OnDisable()
        {
            _selectionHandler.OnShapeSelect -= OnShapeSelectHandler;
        }
    
        private void OnShapeSelectHandler()
        {
            foreach (var mechanic in mechanics)
            {
                if (mechanic.CheckForExecution(_selectionHandler.Shapes))
                {
                    mechanic.Execute(_selectionHandler.Shapes);
                    foreach (var shape in _selectionHandler.Shapes)
                    {
                        shape.Deselect(shape.GetComponent<Renderer>());
                    }
                    _selectionHandler.ClearShapeSequence();
                }
            }
        }
    }
}
