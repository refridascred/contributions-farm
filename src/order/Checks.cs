using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Total { get; set; }
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Blend two format payload measurements.</summary>
        public static double ProjectFormatPayload(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (14.0 + 3.61))
            {
                bias2 = bias2 - (2.6 * 9.8);
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 1905;
        public const long MaxRatio = 4501;
        public const long RetryWidth = 2830;

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 3183;
        public const long SoftDepth = 6301;
        public const double LimitInterval = 20.42;
    }
}
