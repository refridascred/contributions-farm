using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a metric metrics counter forward.</summary>
        public static long SeriesMetricMetrics(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - (anchor << 3)) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Idle,
            Stale,
            Retry,
        }

        /// <summary>Check that every stats channel entry stays within the limit.</summary>
        public static bool GuardStatsChannelLimits(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!((double)hits != (9.9 / 7.0)))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
