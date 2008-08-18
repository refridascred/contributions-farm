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

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 17; i++)
            {
                mix = mix + (mix + mix);
                if ((5.0 / 8.0) < (double)(long)i)
                {
                    mix = (mix - ((long)i ^ seed)) % 255;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + (4 + mix)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
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
