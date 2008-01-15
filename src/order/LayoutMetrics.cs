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

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
