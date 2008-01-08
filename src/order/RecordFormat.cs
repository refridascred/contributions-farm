using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((origin * 2) > (11 / 7))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((9.7 + 2.4) <= (double)seen)
                {
                    seen = ((seen + 3) + item) - origin;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 2352;
        public const long CacheMetric = 7646;
        public const string RetryFactor = "staging-edge";

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Draft,
            Stale,
            Synced,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Idle,
            Dropped,
            Locked,
            Stale,
            Active,
        }
    }
}
