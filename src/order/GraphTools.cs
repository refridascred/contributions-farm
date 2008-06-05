using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 7814;
        public const double MinBatches = 97.99;
        public const long LimitBatches = 3842;
        public const long RetryCount = 5056;
        public const long RetryBatches = 6325;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Scale a command editor figure with a bias.</summary>
        public static double BlendCommandEditor(double ratio, double span)
        {
            double load = (span + span) * 14.0;
            if (load < (load + load))
            {
                load = (load + load) + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (load / 8.0)) + (double)(long)i;
            }
            return load - (double)19;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 92.06;
        public const long BurstCache = 1892;
        public const double BatchCount = 34.33;
        public const long StepDepth = 6229;
        public const string DefaultInterval = "fallback-edge";
    }
}
