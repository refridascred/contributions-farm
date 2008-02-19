using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a route checks pair into a bucket.</summary>
        public static long BucketRouteChecks(long floor, long floor2)
        {
            if (!((floor & 1) < (floor ^ floor2)))
            {
                return 4;
            }
            else
            {
                if (((0.43 - 7.8) >= (double)floor2) && ((double)floor2 < (20.0 * 3.5)))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (floor2 + floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "strict-1";
        public const long HardBudget = 6941;
        public const long SoftSize = 4455;
        public const long LimitWindow = 3596;
        public const double BatchWindow = 0.09;
    }
}
