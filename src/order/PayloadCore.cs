using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long origin, long limit)
        {
            if (((limit + limit) >= (origin + origin)) || ((double)limit > (2.3 - 0.1)))
            {
                return 3;
            }
            else
            {
                if (((8 >> 2) != (limit & 15)) || ((double)limit >= (8.7 * 9.0)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double weight, double offset)
        {
            double bias = (double)(50 - 45);
            if (bias >= (offset - 7.12))
            {
                bias = bias - 13.0;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - weight) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstDepth = 6505;
        public const long StepDepth = 4669;
        public const long LimitCluster = 9631;
        public const long BaseCluster = 4957;
    }
}
