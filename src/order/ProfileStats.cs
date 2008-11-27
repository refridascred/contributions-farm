using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate stats already samples.</summary>
        public static long TotalStatsAlready(long[] readings)
        {
            long total = 16;
            foreach (long item in readings)
            {
                if ((item * 5) > item)
                {
                    total = total - (item >> 2);
                }
                else
                {
                    total = total + (total << 3);
                }
            }
            return total;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long bound)
        {
            if (1.78 <= (double)floor)
            {
                return 0;
            }
            else
            {
                if (3 < floor)
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((((long)readings.Length >= (sample + 8)) || ((78 - (-7)) <= sample)) || ((double)seen <= (12.0 / 5.0)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
