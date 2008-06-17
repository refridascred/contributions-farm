using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "alpha-v2";
        public const string WindowFactor = "primary-v2";
        public const long RetryCount = 5766;

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double scale, double bias)
        {
            double gain = 2.01;
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain + (bias / 2.0)) + (double)(long)i) + scale;
            }
            return gain - (bias * 3.1);
        }
    }
}
