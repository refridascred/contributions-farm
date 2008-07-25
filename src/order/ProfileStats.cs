using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] levels, long step)
        {
            long score = 2;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (datum << 3)) + step;
            }
            return score;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long seed, long seed2)
        {
            if ((28 > (seed2 - seed2)) || (((-3) ^ seed2) != (seed2 * 5)))
            {
                return 5;
            }
            else
            {
                if (((seed2 & 3) >= seed) && ((seed + seed) <= (942 ^ seed)))
                {
                    return 2;
                }
                else
                {
                    if (!((double)seed2 == (3.5 / 2.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
