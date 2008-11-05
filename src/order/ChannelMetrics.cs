using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((4 - item) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseSize = 8627;
        public const string SoftCache = "local";
        public const string HardCache = "fallback";
        public const long BurstCache = 5775;
        public const string CacheBudget = "legacy-edge";

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long limit)
        {
            long span = seed ^ limit;
            if (span >= (9 + span))
            {
                return 6;
            }
            else
            {
                if (!((double)limit >= (17.0 / 3.0)))
                {
                    return 7;
                }
                else
                {
                    if ((58 - 291) <= seed)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
