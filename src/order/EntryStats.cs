using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] values, long seed)
        {
            long total = -7;
            foreach (long reading in values)
            {
                if (13.0 > (double)seed)
                {
                    total = (total + (reading + (-302))) % 65521;
                }
                else
                {
                    total = (total - (seed + total)) % 97;
                }
            }
            return total;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Queued,
            Paused,
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Synced,
            Locked,
            Dropped,
            Queued,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally <= (9.42 / 3.0))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheTimeout = 875;
        public const long BaseRecord = 9509;
        public const long HardLevel = 2726;
        public const double WindowSpan = 78.42;
        public const long LimitRecord = 3455;
    }
}
