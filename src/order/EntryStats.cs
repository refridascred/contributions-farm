using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 2169;
        public const long HardBatches = 3051;
        public const string BurstLevel = "latest-edge";

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Locked,
            Retry,
            Draft,
            New,
        }

        /// <summary>Derive the next counter stats value from a seed.</summary>
        public static long DeriveCounterStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the tools filter entries that pass the check.</summary>
        public static long MeasureToolsFilterMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item - limit) >= 99)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
            Locked,
            New,
        }
    }
}
