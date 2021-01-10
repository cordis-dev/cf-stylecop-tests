using System;

namespace Tests
{
    public class NullableReferenceTypes
    {
        public string? FirstName { get; set; }
        private static byte[]? testBytes;

        public static void Test(Exception e, object obj)
        {
            if (obj is string { Length: 5, Name: "A" } objValue)
            {
                Console.WriteLine(objValue);
            }

            if (e is not null)
            {
                // ...
            }
			
			// indexer nullability
			var strings = new string[] {"A"};
            var z= strings[0]!;
			
			Type?[]? targetTypes = null;
			
			if (pi.ParameterType.GetElementType()!.IsEnum)
			{
			}
			
			cpc.FindConnectionPoint(out cp!);
			
			var errorMessage = new
            {
				a?.b
            };
        }
    }
}