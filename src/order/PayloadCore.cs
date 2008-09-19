using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                mark = (mark - 4) % 4096;
                if ((sample * 5) <= (sample + 0))
                {
                    mark = (mark - (mark + sample)) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] data, long seed)
        {
            long score = -938;
            foreach (long datum in data)
            {
                score = ((score - (datum ^ datum)) % 65521) + seed;
            }
            return score;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
