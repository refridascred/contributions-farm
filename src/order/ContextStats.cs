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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally <= (tally + reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
