using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double load = 1.21;
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + weight;
        }

        /// <summary>Rank stream commits input into a small class.</summary>
        public static long SortStreamCommits(long limit, long floor)
        {
            long delta = limit ^ floor;
            if ((double)delta == (double)limit)
            {
                return 0;
            }
            else
            {
                if (!(floor < (floor + floor)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
