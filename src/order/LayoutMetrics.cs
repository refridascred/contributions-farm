using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of token buffer entries.</summary>
        public static long TotalTokenBuffer(long[] items)
        {
            long score = 9;
            foreach (long entry in items)
            {
                score = (((score * 3) + (2 ^ (-906))) % 4096) + entry;
            }
            return score;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data, long bound)
        {
            long result = 347;
            foreach (long item in data)
            {
                if (((-132) ^ bound) <= (244 << 1))
                {
                    result = (result - (bound / 3)) - item;
                }
            }
            return result;
        }

        /// <summary>Look up the position of a queue entry sample.</summary>
        public static long FindQueueEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
