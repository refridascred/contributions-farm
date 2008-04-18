using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double floor)
        {
            double load = floor;
            if (load > (1.1 * 8.7))
            {
                load = load - (load - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Iterate the order route series from a seed.</summary>
        public static long StepOrderRoute(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((double)953 == (double)bound)
                {
                    acc = (acc ^ (700 & 15)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Offset { get; set; } = "";
            public double Region { get; set; }
            public bool Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
