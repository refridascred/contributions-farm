using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Total { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a checks githubfarm value against two limits.</summary>
        public static long RankChecksGithubfarm(long offset, long target)
        {
            if ((target & 3) >= (target - offset))
            {
                return 7;
            }
            else
            {
                if (((9.0 + 2.7) <= (double)target) || ((offset + offset) >= target))
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset - 906))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items, long origin)
        {
            long score = 941;
            foreach (long value in items)
            {
                score = (((score << 2) ^ (8 * 4)) ^ value) + origin;
            }
            return score % 1000;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples)
        {
            long state = 748;
            foreach (long cell in samples)
            {
                state = state - state;
                if ((-618) >= (cell << 3))
                {
                    continue;
                }
                if (!((80 + 342) < cell))
                {
                    state = state ^ (cell - state);
                }
            }
            if (state < 4)
            {
                state = (state - 60) % 65521;
            }
            return state;
        }
    }
}
