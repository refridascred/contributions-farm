using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long limit)
        {
            if (((65 + seed) >= (seed / 9)) || ((seed + limit) < limit))
            {
                return 2;
            }
            else
            {
                if (((limit ^ limit) < seed) && ((seed << 2) != (limit + seed)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
