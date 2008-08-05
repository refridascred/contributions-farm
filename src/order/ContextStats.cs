using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long offset, long offset2)
        {
            if (((4 / 6) <= (offset2 / 8)) || ((offset ^ offset2) >= (offset2 + 425)))
            {
                return 1;
            }
            else
            {
                if ((864 - 9) >= offset2)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] series)
        {
            long mark = 2;
            foreach (long reading in series)
            {
                if ((mark - mark) == (reading - (long)series.Length))
                {
                    mark = (mark ^ (reading & 1)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
