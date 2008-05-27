using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 53.0;
        public const long IdleCommand = 3679;
        public const long BatchInterval = 3613;
        public const string DefaultTimeout = "cached-v2";
        public const double CacheTimeout = 14.05;

        /// <summary>Count the record cache entries that pass the check.</summary>
        public static long MeasureRecordCacheOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (target < (target ^ value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((15.0 * 7.9) <= (double)tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }
    }
}
