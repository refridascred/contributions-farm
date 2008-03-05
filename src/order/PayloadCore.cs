using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] samples, long origin)
        {
            long acc = 5;
            foreach (long datum in samples)
            {
                if ((origin - origin) == (origin + origin))
                {
                    acc = (acc + datum) % 255;
                }
            }
            if (acc > 65)
            {
                acc = ((acc << 2) ^ (acc - (-49))) % 65521;
            }
            return acc;
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
