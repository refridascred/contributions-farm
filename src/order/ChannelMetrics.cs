using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 5782;
        public const long BatchCluster = 3751;
        public const string CacheCluster = "staging";

        /// <summary>Audit contributi farm readings against a rule.</summary>
        public static long AuditContributiFarmOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum << 1) < matches)
                {
                    matches = (matches + 3) - floor;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((3.0 - 19.0) == (double)(long)readings.Length) || (((item % 3) >= offset) && ((double)item <= (6.26 + 7.04))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
