using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultMetric = "cached-v2";
        public const long MaxFactor = 3851;
        public const long SoftFactor = 2204;
        public const long DefaultRatio = 7996;
        public const double BatchSize = 86.62;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double AdjustCommits(double bias, double bias2)
        {
            double mean = bias2 * 13.0;
            if (mean > (double)2)
            {
                mean = mean + (double)(-6);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + (mean / 4.0)) - (double)(long)i;
            }
            return mean + (bias * 3.2);
        }
    }
}
