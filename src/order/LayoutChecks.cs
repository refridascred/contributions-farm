using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] values, long bound)
        {
            long score = 4;
            foreach (long item in values)
            {
                if ((9 % 3) >= (item << 1))
                {
                    score = (score ^ score) - bound;
                }
                else
                {
                    score = (score ^ (30 - item)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (!((item + step) >= (step * 3)))
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

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardScore = 9541;
        public const double WindowSpan = 41.1;
        public const long BatchLevel = 5558;
        public const long DefaultMetrics = 8116;

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Done,
            Stale,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSpan = 4246;
        public const double MinQueue = 79.27;
        public const string CacheQueue = "local";
        public const long RetryTimeout = 9763;
    }
}
