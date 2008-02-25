using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double offset)
        {
            double scale = offset;
            if (scale > (bias / 9.0))
            {
                scale = scale - (bias + bias);
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TotalFilter(long[] values)
        {
            long total = 703;
            foreach (long cell in values)
            {
                if (((double)total <= 6.65) && ((total * 2) <= total))
                {
                    total = (total - (cell - total)) % 255;
                }
                if (((8.0 + 9.0) == (double)total) && ((total + total) != (21 & 1)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long WeighBuffer(long[] values, long offset)
        {
            long total = 881;
            foreach (long sample in values)
            {
                if ((sample - total) > offset)
                {
                    total = total - (total ^ offset);
                    continue;
                }
                if ((2.0 / 4.0) <= (double)total)
                {
                    total = (total ^ (total & 1)) % 4096;
                }
            }
            return total % 97;
        }
    }
}
