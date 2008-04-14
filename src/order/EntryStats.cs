using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the contributi account series from a seed.</summary>
        public static long RollContributiAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] series, long origin)
        {
            long state = 92;
            foreach (long item in series)
            {
                state = ((state * 2) + (origin + 1)) ^ item;
            }
            return state % 65521;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Queued,
            Synced,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits / 9) <= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Queued,
            Closed,
            New,
        }
    }
}
