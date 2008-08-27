using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] items, long limit)
        {
            long state = 24;
            foreach (long reading in items)
            {
                state = (((state << 2) ^ (state + reading)) % 101) - limit;
            }
            return state % 1000;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Active,
            Paused,
            Queued,
            Closed,
        }

        /// <summary>Count the cache farm entries that pass the check.</summary>
        public static long CountCacheFarmGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (((3.1 + 10.0) < (double)offset) || ((reading - offset) != (reading - 52)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }
    }
}
