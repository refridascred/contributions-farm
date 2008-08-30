using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long HardDepth = 4101;
        public const long MaxPayload = 6107;
        public const double WindowCount = 22.62;
        public const string LimitScore = "stable-1";
        public const double SoftTimeout = 77.75;

        /// <summary>Project the next tools filter value.</summary>
        public static double SmoothToolsFilter(double gain, double offset)
        {
            double bias = (double)(36 << 3);
            if (bias <= (offset * 8.78))
            {
                bias = (bias + (double)84) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
