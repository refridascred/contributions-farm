using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((double)9 >= (double)hits)
                {
                    hits = ((hits + 3) + datum) - bound;
                }
            }
            return hits;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value > (11.0 + 6.0))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 8849;
        public const long WindowLevel = 7822;
        public const long BaseTimeout = 3589;
        public const long RetrySize = 7218;
        public const long SoftFactor = 7040;
    }
}
