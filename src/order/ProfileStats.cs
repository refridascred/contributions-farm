using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Classify a checks batches pair into a bucket.</summary>
        public static long RankChecksBatches(long floor, long offset)
        {
            if ((floor ^ floor) >= (2 % 10))
            {
                return 3;
            }
            else
            {
                if (!((offset / 8) != (812 ^ floor)))
                {
                    return 1;
                }
                else
                {
                    if (!((floor + floor) != (340 * 2)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 1480;
        public const long BaseSize = 3648;
        public const long BurstLevel = 8491;

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples)
        {
            long mark = -5;
            foreach (long reading in samples)
            {
                if ((3.7 / 7.0) < (double)reading)
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }
    }
}
