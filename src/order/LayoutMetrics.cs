using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double bias, double bias2)
        {
            double weight = bias;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + bias) + (double)(long)i) - bias2;
            }
            return weight - (bias / 9.0);
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
