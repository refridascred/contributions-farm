using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long score = 13;
            foreach (long item in items)
            {
                score = score - score;
                if ((item >> 4) == (0 + item))
                {
                    score = ((score << 2) ^ score) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Stale,
            Synced,
        }
    }
}
