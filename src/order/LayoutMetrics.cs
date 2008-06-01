using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next batch counter value.</summary>
        public static double SmoothBatchCounter(double rate, double floor)
        {
            double scale = (double)7 + rate;
            if (scale <= (floor + rate))
            {
                scale = scale + (double)575;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (15.0 + rate);
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
