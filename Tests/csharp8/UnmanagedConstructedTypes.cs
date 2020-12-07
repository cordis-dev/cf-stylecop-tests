using System;

namespace Tests
{
    public struct Coords<T>
    {
        public T X;
        public T Y;
    }

    public class UnmanagedConstructedTypes
    {
        public void Test()
        {
            Span<Coords<int>> coordinates = stackalloc[]
            {
                new Coords<int> { X = 0, Y = 0 },
                new Coords<int> { X = 0, Y = 3 },
                new Coords<int> { X = 4, Y = 0 }
            };
        }
    }
}