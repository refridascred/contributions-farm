using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long seed)
        {
            long score = 611;
            foreach (long entry in samples)
            {
                if (!(seed < (entry & 3)))
                {
                    score = ((score << 2) ^ (entry << 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Done,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Closed,
            Ready,
            Locked,
        }
    }
}
