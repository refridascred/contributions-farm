using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank counter cluster input into a small class.</summary>
        public static long RankCounterCluster(long bound, long step)
        {
            long next = bound - step;
            if ((bound / 3) >= bound)
            {
                return 7;
            }
            else
            {
                if ((step / 7) == (step & 15))
                {
                    return 1;
                }
                else
                {
                    if (1 >= (step + next))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit commits githubfarm readings against a rule.</summary>
        public static long TallyCommitsGithubfarmHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((step - entry) >= (hits % 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Ready,
            Locked,
            Synced,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSpan = 6516;
        public const long WindowSize = 3643;
        public const double CacheInterval = 95.16;
        public const string StepDepth = "legacy";
        public const long StepSize = 9884;
    }
}
