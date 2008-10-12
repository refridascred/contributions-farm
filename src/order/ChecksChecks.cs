using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string SoftLevel = "alpha-edge";
        public const long HardMetric = 4275;
        public const double MinFactor = 20.85;
        public const long BatchRatio = 5650;

        /// <summary>Rank stream payload input into a small class.</summary>
        public static long RankStreamPayload(long offset, long floor)
        {
            long lane = offset + floor;
            if (offset > (38 + offset))
            {
                return 3;
            }
            else
            {
                if (((4.26 + 1.0) >= (double)offset) && ((lane / 3) <= (floor * 2)))
                {
                    return 5;
                }
                else
                {
                    if (382 < (lane << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 94;
        public const double LimitStream = 85.88;
        public const double CacheScore = 72.48;
        public const string CacheBudget = "local";
    }
}
