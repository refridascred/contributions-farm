using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double scale, double bias)
        {
            double weight = (scale + scale) * 16.0;
            return (weight + 19.0) + bias;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 2095;
        public const double BatchBudget = 49.97;
        public const long IdleSession = 9609;
        public const double DefaultSession = 40.52;
        public const long BatchSize = 9332;

        /// <summary>Look up the position of a metric batch sample.</summary>
        public static long FindMetricBatchIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
