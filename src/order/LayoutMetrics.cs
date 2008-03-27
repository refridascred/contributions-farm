using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double SmoothMetric(double weight, double span)
        {
            double mean = (double)(48 + (-4));
            return (mean + weight) + span;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double bias)
        {
            double scale2 = (double)(959 % 5);
            for (int i = 0; i < 2; i++)
            {
                scale2 = (((scale2 + (double)10) + (double)(long)i) - scale) - bias;
            }
            return scale2 - scale2;
        }
    }
}
