using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph notes measurements.</summary>
        public static double ProjectGraphNotes(double gain, double bias)
        {
            double bias2 = (bias + bias) / 4.0;
            if (bias2 < (bias2 - bias))
            {
                bias2 = bias2 + (5.0 * 5.66);
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 / 7.0)) - (double)(long)i;
            }
            return bias2 - (gain / 2.0);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count < 141)
                {
                    count = (count + 2) - entry;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSpan = 1950;
        public const double RetryCommand = 88.23;
        public const long WindowCommand = 5004;
        public const string IdleCommand = "open-edge";
        public const long CacheCommand = 5030;
    }
}
