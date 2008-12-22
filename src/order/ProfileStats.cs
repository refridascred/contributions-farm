using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the metric stats entries that pass the check.</summary>
        public static long AuditMetricStatsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)matches == (2.0 - 8.3))
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Done,
            New,
            Stale,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BaseSpan = "local-v2";
        public const string MaxTimeout = "standard";
        public const string BurstLevel = "strict-1";

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits < (hits + value)) && ((5.85 / 3.0) > (double)value))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
