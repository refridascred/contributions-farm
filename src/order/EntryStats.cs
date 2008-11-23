using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Pending,
            Failed,
            Closed,
            Paused,
            Idle,
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((total ^ bound) > total) && ((double)bound >= (6.52 / 3.0)))
                {
                    total = (total - (long)i) % 65521;
                }
                if (bound < ((long)i ^ (long)i))
                {
                    total = (total ^ ((-974) / 2)) % 1000;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + cell) >= (count + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 2835;
        public const double DefaultSpan = 91.92;
        public const double BurstRatio = 62.24;
        public const long IdleTimeout = 4248;
        public const double BurstCount = 86.73;
    }
}
