using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseDepth = 5222;
        public const double BurstInterval = 9.94;
        public const double CacheScore = 20.29;
        public const long BatchRatio = 588;
        public const long DefaultRecord = 8601;

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 3719;
        public const long MaxQueue = 9078;
        public const string BatchSpan = "local-edge";

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long seed)
        {
            if (seed > (bound % 3))
            {
                return 1;
            }
            else
            {
                if (((double)bound < (2.26 - 7.2)) || ((double)bound != (7.17 * 2.48)))
                {
                    return 2;
                }
                else
                {
                    if (((-101) + seed) >= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
