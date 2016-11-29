using System;

namespace Common.Utilities
{
    /// <summary>Farm format helpers.</summary>
    public static class FarmFormat
    {
        /// <summary>Check whether a digest size is a power of two.</summary>
        public static bool IsDigestPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
