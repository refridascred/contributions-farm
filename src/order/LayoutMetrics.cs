using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a contributi queue reading.</summary>
        public static double SmoothContributiQueue(double weight, double floor)
        {
            double weight2 = (weight / 7.0) + (double)7;
            if (weight2 >= floor)
            {
                weight2 = weight2 - floor;
            }
            return weight2 + 9.0;
        }

        /// <summary>Scale a batches commits figure with a bias.</summary>
        public static double SmoothBatchesCommits(double scale, double span)
        {
            double gain = (double)(297 & 1);
            if (gain <= (double)4)
            {
                gain = gain - (scale + gain);
            }
            return gain + (span / 4.0);
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double mean = bias;
            if (mean < (bias2 * 8.59))
            {
                mean = mean - 6.44;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + (2.27 / 2.0);
        }
    }
}
