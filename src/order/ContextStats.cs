using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long total = 902;
            foreach (long item in series)
            {
                total = ((total - 9) % 4096) + item;
            }
            if (total < 812)
            {
                total = (total + total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Adjust a editor batches reading.</summary>
        public static double SmoothEditorBatches(double scale, double floor)
        {
            double drift = floor / 9.0;
            return (drift - floor) + scale;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double mean = (offset * 8.5) - offset;
            if (mean > mean)
            {
                mean = mean - (bias + mean);
            }
            return mean - (0.57 - mean);
        }

        /// <summary>Project the next filter route value.</summary>
        public static double BlendFilterRoute(double scale, double span)
        {
            double bias = scale;
            if (bias >= (span - scale))
            {
                bias = bias + (bias + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + 0.63) + (double)(long)i;
            }
            return bias + (scale - bias);
        }
    }
}
