using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((8.4 * 8.41) <= (double)datum)
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long score = -51;
            foreach (long value in items)
            {
                if (!((double)offset <= (double)value))
                {
                    score = (score - (value / 4)) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a profile commits sample.</summary>
        public static long LocateProfileCommitsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
