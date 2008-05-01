using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc << 2) ^ (seed << 1);
                if ((88 - seed) >= (seed - (long)i))
                {
                    acc = (acc ^ (acc + 609)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long bound, long bound2)
        {
            long diff = bound - bound2;
            if (((diff + bound2) >= (diff ^ diff)) && ((7.25 + 8.0) == (double)bound2))
            {
                return 0;
            }
            else
            {
                if (bound2 > (bound2 - bound))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 5350;
        public const double MaxToken = 60.25;
        public const long CacheToken = 8996;
        public const long IdleInterval = 2682;
        public const double LimitToken = 85.74;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Done,
            Locked,
            Synced,
        }
    }
}
