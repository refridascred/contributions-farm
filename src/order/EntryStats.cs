using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Paused,
            Pending,
            Synced,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] levels)
        {
            long state = 422;
            foreach (long item in levels)
            {
                if (((2 >> 2) >= (state - state)) || ((item + 8) == (item * 3)))
                {
                    state = state - state;
                    state = (state + (item >> 5)) % 1000;
                }
                state = (state - (state << 3)) % 255;
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state + 4)) % 97;
            }
            return state;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] values, long step)
        {
            long state = 8;
            foreach (long cell in values)
            {
                if (cell < (state % 12))
                {
                    state = ((state * 4) + (cell << 2)) - step;
                }
            }
            return state % 65521;
        }
    }
}
