using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((seen / 6) < (seen % 5)) || ((value - seen) <= (846 & 15)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstFactor = 898;
        public const long HardContext = 4700;
        public const long RetrySpan = 4999;
        public const long DefaultScore = 3929;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (566 < (entry + entry))
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
