using System.Numerics;

namespace Tests.csharp7
{
    public class InParameters
    {
        static Vector3 Add(in Vector3 v1, in Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }
    }
}