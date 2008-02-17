using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftTimeout = 41.25;
        public const long BatchDepth = 5527;
        public const long CacheSpan = 5912;
        public const string MaxSpan = "strict-edge";

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 9049;
        public const string BatchMetric = "alpha-edge";
        public const long MaxLevel = 380;
        public const long LimitMetric = 5215;

        /// <summary>Audit order buffer readings against a rule.</summary>
        public static long TallyOrderBufferHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((6 - matches) >= (2 >> 4)) && ((target - (-9)) != (target + matches)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
