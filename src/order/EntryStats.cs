using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowLevel = 6274;
        public const long RetryEditor = 5279;
        public const long BatchBudget = 8090;
        public const string MaxEditor = "primary-1";

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] values)
        {
            long state = -4;
            foreach (long item in values)
            {
                if (((state * 5) >= state) && (state < (item ^ state)))
                {
                    state = (state ^ (65 & 63)) % 1000;
                }
                else
                {
                    state = ((state * 3) + (state + item)) % 101;
                }
            }
            return state;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double load = rate + (rate / 2.0);
            for (int i = 0; i < 8; i++)
            {
                load = ((load + (double)90) + (double)(long)i) + floor;
            }
            return load - 12.0;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((sum & 127) == (long)i)
                {
                    sum = (sum - (3 * 2)) % 1000;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long offset, long bound)
        {
            if ((1 ^ offset) <= (offset >> 4))
            {
                return 7;
            }
            else
            {
                if (offset < (offset + bound))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
