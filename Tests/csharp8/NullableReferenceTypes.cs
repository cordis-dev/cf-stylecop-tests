using System;

namespace Tests
{
    public class NullableReferenceTypes
    {
        public string? FirstName { get; set; }
        private static byte[]? testBytes;

        public static void Test(Exception e, object obj)
        {
            if (obj is string { Length: 5 } objValue)
            {
                Console.WriteLine(objValue);
            }

            if (e is not null)
            {
                // ...
            }
        }
    }
}