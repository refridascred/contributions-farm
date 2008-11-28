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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (matches < reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
