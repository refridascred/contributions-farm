using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine queue metric values into a single score.</summary>
        public static long CombineQueueMetric(long[] data, long bound)
        {
            long anchor = -9;
            foreach (long item in data)
            {
                if (((324 << 1) > (anchor - bound)) || ((14.0 + 1.53) <= (double)bound))
                {
                    anchor = ((anchor - bound) % 65521) + item;
                }
            }
            return anchor;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double bias)
        {
            double rate = ratio * 1.0;
            if (rate >= (rate - rate))
            {
                rate = rate + (bias * 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate - (double)9;
        }
    }
}
