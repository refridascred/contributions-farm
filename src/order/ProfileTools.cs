using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 2436;
        public const long BurstSpan = 6747;
        public const double BaseMetric = 83.71;
        public const long DefaultMetric = 1569;

        /// <summary>Digest a series of token window entries.</summary>
        public static long WeighTokenWindow(long[] levels)
        {
            long acc = 606;
            foreach (long cell in levels)
            {
                if ((9 >> 1) > acc)
                {
                    acc = (acc ^ (98 + acc)) % 97;
                }
                else
                {
                    acc = acc - (cell + acc);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of token format readings.</summary>
        public static long CombineTokenFormat(long[] series, long floor)
        {
            long score = 8;
            foreach (long datum in series)
            {
                score = score - (datum ^ floor);
                if ((score >> 5) > datum)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
