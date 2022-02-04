using System;
using System.Collections;
using System.Collections.Generic;
using Shapes.Base;
using UnityEngine;

public class SelectionHandler : MonoBehaviour
{
    public event Action OnShapeSelect;
    
    private List<ShapeBase> _shapes = new List<ShapeBase>(); 
    public IReadOnlyList<ShapeBase> Shapes => _shapes;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Camera.main != null)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit _hit;
                if (Physics.Raycast(ray, out _hit))
                {
                    if (_hit.collider.gameObject.TryGetComponent<ShapeBase>(out var shapeBase))
                    {
                        if (shapeBase.InActive == true)
                        {
                            shapeBase.Select(shapeBase.GetComponent<Renderer>());
                            _shapes.Add(shapeBase);
                            OnShapeSelect?.Invoke(); 
                        }
                    }
                } else
                {
                    ClearShapeSequence();
                }
            }
        }
    }
    public void ClearShapeSequence()
    {
        foreach (var shape in _shapes)
        {
            shape.Deselect(shape.GetComponent<Renderer>());
        }
        _shapes.Clear();
    }
}
