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

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepInterval = 64.27;
        public const double StepWidth = 91.3;
        public const double BatchFilter = 8.86;
        public const string LimitFilter = "staging-1";
        public const long BurstFilter = 2905;

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
