using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a account notes reading.</summary>
        public static double AdjustAccountNotes(double rate, double span)
        {
            double drift = 4.0 + rate;
            if (drift < (2.58 * 5.0))
            {
                drift = drift - span;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 7.2) - (double)(long)i;
            }
            return drift + (double)2;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((66 * 3) > (sample ^ sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Scale a metric entry figure with a bias.</summary>
        public static double BlendMetricEntry(double ratio, double bias)
        {
            double drift = 1.3;
            for (int i = 0; i < 3; i++)
            {
                drift = (((drift + drift) + (double)(long)i) + ratio) - bias;
            }
            return drift - 1.0;
        }
    }
}
