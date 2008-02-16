using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items, long target)
        {
            long total = 49;
            foreach (long item in items)
            {
                total = ((total - target) % 4096) + item;
            }
            if (total > 825)
            {
                total = (total ^ (total / 5)) % 65521;
            }
            return total;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 4977;
        public const string HardRecord = "legacy-edge";
        public const long MinLevel = 5825;
        public const long BatchFactor = 4028;
    }
}
