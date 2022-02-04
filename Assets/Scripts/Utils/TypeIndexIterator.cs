namespace Utils
{
    public static class TypeIndexIterator
    {
        private static int _currentIndex;

        public static int GetNewIndex()
        {
            return ++_currentIndex;
        }
    }
}