using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double gain = 2.0;
            for (int i = 0; i < 9; i++)
            {
                gain = (((gain + gain) + (double)(long)i) - scale) - bias;
            }
            return gain + 2.8;
        }

        /// <summary>Find the first layout session entry that matches the target.</summary>
        public static long LookupLayoutSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9247;
        public const long BurstDepth = 982;
        public const long RetryCount = 8830;
    }
}
