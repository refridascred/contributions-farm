using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Closed,
            Idle,
            Pending,
            Retry,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((seed & 15) > mark)
                {
                    mark = mark ^ (long)i;
                    mark = mark ^ 502;
                }
                if ((double)(long)i != (double)21)
                {
                    mark = (mark ^ (mark - mark)) % 97;
                    mark = (mark << 3) ^ ((long)i * 4);
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
