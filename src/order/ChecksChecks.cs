using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardWidth = "local-1";
        public const double HardDepth = 56.88;
        public const string BurstSize = "local-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultDepth = 5691;
        public const string CacheOrder = "alpha";
        public const long StepCount = 4583;
        public const double IdleOrder = 68.86;

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long origin, long floor)
        {
            if ((double)origin != (double)floor)
            {
                return 8;
            }
            else
            {
                if ((double)9 >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
