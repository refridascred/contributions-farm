using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long offset)
        {
            long mark = 775;
            foreach (long value in items)
            {
                if (!(offset <= mark))
                {
                    mark = ((mark * 5) + mark) ^ value;
                }
                else
                {
                    mark = mark ^ (offset * 5);
                }
            }
            if (mark > 5)
            {
                mark = (mark - (-187)) % 65521;
            }
            return mark;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((2.93 + 7.2) == (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate payload cache readings against a bound.</summary>
        public static bool ValidatePayloadCacheRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
