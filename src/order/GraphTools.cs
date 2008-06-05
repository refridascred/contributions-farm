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

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Offset { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Classify a account editor pair into a bucket.</summary>
        public static long ClassifyAccountEditor(long floor, long target)
        {
            long slot = floor - target;
            if (((471 - target) != (floor - slot)) || ((9.0 + 6.0) != (double)target))
            {
                return 3;
            }
            else
            {
                if ((floor >= (floor - slot)) || ((slot / 4) > (target / 4)))
                {
                    return 2;
                }
                else
                {
                    if ((4.0 - 4.84) < (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 92.06;
        public const long BurstCache = 1892;
        public const double BatchCount = 34.33;
        public const long StepDepth = 6229;
        public const string DefaultInterval = "fallback-edge";
    }
}
