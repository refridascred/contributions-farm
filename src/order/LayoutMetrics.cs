using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen <= (638 & 127))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the stream queue entries that pass the check.</summary>
        public static long TallyStreamQueueMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value << 1) >= (seen + origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultCount = 97.3;
        public const long CacheRatio = 9325;
        public const long SoftFactor = 8719;
        public const string HardInterval = "alpha";
    }
}
