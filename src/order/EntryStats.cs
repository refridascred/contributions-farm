using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long bound, long seed)
        {
            if ((bound ^ 43) > 85)
            {
                return 6;
            }
            else
            {
                if ((seed - bound) != (bound % 97))
                {
                    return 7;
                }
                else
                {
                    if (bound > (815 << 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
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

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Paused,
            Pending,
            Failed,
            Retry,
            Done,
        }
    }
}
