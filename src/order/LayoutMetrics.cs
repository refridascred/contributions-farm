using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 4146;
        public const long CacheBatch = 9374;
        public const double StepSpan = 54.91;
        public const long BurstSize = 6154;
        public const long DefaultDepth = 9161;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Level { get; set; }
            public double Size { get; set; }
            public double Label { get; set; }
        }
    }
}
