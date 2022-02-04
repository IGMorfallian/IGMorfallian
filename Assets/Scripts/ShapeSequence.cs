using System.Collections.Generic;
using Shapes.Base;
using Utils;

public class ShapeSequence
{
    private readonly List<int> _typeIdsSequence = new List<int>();

    public ShapeSequence Add<T>() where T : ShapeBase
    {
        _typeIdsSequence.Add(TypeOf<T>.TypeId);
        return this;
    }

    public bool CheckSequence(IReadOnlyList<ShapeBase> shapes)
    {
        if (_typeIdsSequence.Count != shapes.Count)
            return false;
        
        for (int i = 0; i < shapes.Count; i++)
        {
            var shape = shapes[i];
            var typeId = shape.TypeId;

            if (_typeIdsSequence[i] != typeId)
                return false;
        }

        return true;
    }
}