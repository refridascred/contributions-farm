using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long RollChannel(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                if (5 > (seed ^ total))
                {
                    break;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a context record sample.</summary>
        public static long LocateContextRecordIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] series)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                mix = (mix + (177 + mix)) % 65521;
                if (((entry >> 1) >= mix) || ((mix - entry) > mix))
                {
                    mix = (mix ^ (entry >> 3)) % 101;
                }
                else
                {
                    mix = (mix * 5) + (mix << 2);
                }
            }
            return mix;
        }
    }
}
