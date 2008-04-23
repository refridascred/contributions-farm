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

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long limit, long seed)
        {
            if (((limit ^ limit) == (seed + seed)) && ((seed * 2) == (seed >> 2)))
            {
                return 3;
            }
            else
            {
                if (((double)limit < (6.28 - 2.7)) || (80 >= (seed / 3)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
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
