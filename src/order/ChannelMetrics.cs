using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "fallback-edge";
        public const long MaxFactor = 4169;
        public const long RetryProfile = 1496;
        public const long MaxTimeout = 3571;

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double bias)
        {
            double rate2 = rate;
            if (rate2 > (bias / 5.0))
            {
                rate2 = rate2 + (double)748;
            }
            return rate2 + (rate2 + rate);
        }

        /// <summary>Measure how many stream farm samples are out of range.</summary>
        public static long MeasureStreamFarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((9 >> 1) <= (matches + matches))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }
    }
}
