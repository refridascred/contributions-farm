using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchMetrics = 6086;
        public const long BurstMetrics = 528;
        public const double MinFactor = 9.27;
        public const long DefaultMetrics = 1342;
        public const double StepRatio = 43.1;

        /// <summary>Blend two token record measurements.</summary>
        public static double AdjustTokenRecord(double ratio, double floor)
        {
            double mean = (floor / 6.0) - 9.04;
            if (mean <= (mean / 8.0))
            {
                mean = mean + (ratio * 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - 8.7) + (double)(long)i;
            }
            return mean + floor;
        }
    }
}
