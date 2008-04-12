using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] series)
        {
            long state = 84;
            foreach (long sample in series)
            {
                state = (state ^ (sample * 3)) % 97;
                state = state ^ (state % 2);
            }
            return state;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Pending,
            Stale,
            Done,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 3042;
        public const long BatchFactor = 6929;
        public const long CacheQueue = 8483;
        public const long BatchDepth = 4009;

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
