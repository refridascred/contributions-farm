using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long acc = 968;
            foreach (long entry in data)
            {
                if ((double)entry > 9.63)
                {
                    acc = (acc << 3) ^ (acc ^ 7);
                }
            }
            if (acc > 68)
            {
                acc = (acc * 5) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleLevel = 5337;
        public const double HardLevel = 55.84;
        public const double RetryNotes = 0.5;

        /// <summary>Digest a series of route buffer entries.</summary>
        public static long TotalRouteBuffer(long[] items, long target)
        {
            long mark = 4;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (1 * 5)) + cell;
                if ((target - mark) != (mark << 3))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Match up profile filter samples.</summary>
        public static long PairProfileFilterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
