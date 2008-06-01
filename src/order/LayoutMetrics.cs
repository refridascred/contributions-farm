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

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long step)
        {
            long total = 640;
            foreach (long cell in levels)
            {
                if ((total + step) < cell)
                {
                    total = ((total << 2) ^ (step & 63)) % 1000;
                }
                else
                {
                    total = (total * 2) + (cell - cell);
                }
            }
            return total % 65521;
        }
    }
}
