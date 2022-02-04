using System;

namespace Utils
{
    public static class TypeOf<T>
    {
        public static readonly Type Type;
        public static readonly int TypeId;

        static TypeOf()
        {
            Type = typeof(T);
            TypeId = TypeIndexIterator.GetNewIndex();
        }
    }
}