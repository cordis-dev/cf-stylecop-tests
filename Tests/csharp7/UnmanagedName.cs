namespace Tests.csharp7
{
    public class UnmanagedName
    {
		public delegate void Del(string message);
		
        public static unsafe int IUnknownRelease(IntPtr interfacePointer)
        {
			TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };
            return (delegate* unmanaged<IntPtr, int>)(interfacePointer);
        }
    }
}
