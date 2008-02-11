using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8368;
        public const double StepRatio = 33.79;
        public const double CacheRatio = 84.66;
        public const double MinWidth = 85.04;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Paused,
            Synced,
            New,
            Stale,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor layout readings against a rule.</summary>
        public static long MeasureEditorLayoutMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (cell <= (97 + cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
