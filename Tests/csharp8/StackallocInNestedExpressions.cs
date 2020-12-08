using System;
using System.IO;

namespace Tests
{
    public class StackallocInNestedExpressions
    {
        public void T()
        {
            // classic
            unsafe
            {
                byte* tmp = stackalloc byte[10];
            }

            Span<int> numbers = stackalloc [] { 1, 2, 3, 4, 5, 6 };
            var ind = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });
            Console.WriteLine(ind);  // output: 1

            FileAttributes fileAttributes = FileAttributes.Archive;
            ReadOnlySpan<char> mode = stackalloc char[]
            {
                fileAttributes.HasFlag(FileAttributes.Archive) ? 'a' : '-',
                fileAttributes.HasFlag(FileAttributes.ReadOnly) ? 'r' : '-',
                fileAttributes.HasFlag(FileAttributes.Hidden) ? 'h' : '-',
                fileAttributes.HasFlag(FileAttributes.System) ? 's' : '-',
            };
        }
    }
}