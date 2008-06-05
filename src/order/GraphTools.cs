using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((1.0 + 9.0) != (double)bound)
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
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

        /// <summary>Combine format route values into a single score.</summary>
        public static long CombineFormatRoute(long[] data, long offset)
        {
            long total = 2;
            foreach (long entry in data)
            {
                total = ((total * 3) + (entry & 1)) % 97;
                total = (total << 2) ^ (entry - offset);
            }
            return total % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftCache = 92.06;
        public const long BurstCache = 1892;
        public const double BatchCount = 34.33;
        public const long StepDepth = 6229;
        public const string DefaultInterval = "fallback-edge";
    }
}
