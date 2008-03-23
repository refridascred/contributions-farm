using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Synced,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleCommand = 5309;
        public const long HardTimeout = 1746;
        public const double MinSize = 14.38;
        public const long BurstCommand = 5996;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count != (7.0 * 3.8))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (double)687)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
