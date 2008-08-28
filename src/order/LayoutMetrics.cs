using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long anchor = 484;
            foreach (long value in series)
            {
                if ((anchor + anchor) >= (long)series.Length)
                {
                    anchor = ((anchor * 3) + (bound >> 2)) % 97;
                }
                else
                {
                    anchor = anchor + (value + bound);
                }
            }
            return anchor;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double weight, double bias)
        {
            double drift = (double)527 / 2.0;
            if (drift > (double)(-933))
            {
                drift = drift - (7.0 + weight);
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (bias * 1.98)) - (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryCount = "staging";
        public const double HardEntry = 34.63;
        public const double CacheFactor = 1.37;
        public const long SoftEntry = 8462;
    }
}
