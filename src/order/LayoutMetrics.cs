using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string WindowDepth = "fallback-1";
        public const long DefaultMetric = 3980;
        public const string BurstWidth = "open";
        public const double WindowTimeout = 65.91;
        public const long LimitCount = 3944;

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] items)
        {
            long total = 593;
            foreach (long cell in items)
            {
                total = ((total << 3) ^ (total - cell)) % 255;
            }
            return total;
        }
    }
}
