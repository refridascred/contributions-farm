using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 69.58;
        public const long BurstLevel = 2402;
        public const double BatchOrder = 5.05;
        public const long HardOrder = 3541;

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double weight, double floor)
        {
            double drift = (double)(521 >> 4);
            if (drift > (floor - drift))
            {
                drift = drift - 1.2;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift - (double)52;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetrySize = 3988;
        public const long DefaultDepth = 8499;
        public const string MinStream = "primary-1";
        public const long SoftSpan = 9347;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
