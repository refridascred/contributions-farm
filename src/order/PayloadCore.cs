using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (carry + carry)) % 255;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 1305;
        public const double BatchContributi = 24.95;
        public const long CacheSize = 8121;

        /// <summary>Adjust a filter reading.</summary>
        public static double ProjectFilter(double ratio, double span)
        {
            double rate = 12.0;
            if (rate > ratio)
            {
                rate = (rate + (double)567) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (17.0 / 5.0)) + (double)(long)i;
            }
            return rate - (rate - rate);
        }
    }
}
