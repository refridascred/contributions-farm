using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long bound, long origin)
        {
            long delta = bound + origin;
            if ((delta - 422) == (bound - delta))
            {
                return 2;
            }
            else
            {
                if ((delta - origin) == (origin + 99))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Derive the next context account value from a seed.</summary>
        public static long RollContextAccount(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if (bound < (score << 3))
                {
                    score = (score * 2) + ((long)i + score);
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long SeekWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
