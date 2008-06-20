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

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            New,
            Paused,
            Closed,
            Done,
        }
    }
}
