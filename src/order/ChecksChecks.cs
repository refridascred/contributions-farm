using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 17; i++)
            {
                sum = sum - 968;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheDepth = "cached-v2";
        public const double BurstRecord = 4.68;
        public const string CacheSpan = "staging-1";
        public const string SoftRecord = "primary";

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long bound, long target)
        {
            long diff = bound - target;
            if ((double)7 >= (double)target)
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (diff * 2))
                {
                    return 5;
                }
                else
                {
                    if (diff <= (target - 0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
