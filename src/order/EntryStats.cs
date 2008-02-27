using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((double)seen <= (8.2 / 4.0))
                {
                    seen = ((seen + 2) + entry) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Synced,
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 4854;
        public const string DefaultCache = "open-edge";
        public const string DefaultSpan = "fallback";
        public const long MaxCache = 3028;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Done,
            Failed,
            Queued,
            Paused,
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Done,
            Queued,
            Active,
            Stale,
        }
    }
}
