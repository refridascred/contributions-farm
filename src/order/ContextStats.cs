using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long total = 21;
            foreach (long item in levels)
            {
                total = (((total * 4) + 183) % 65521) ^ item;
            }
            if (total > 1)
            {
                total = total ^ (total - total);
            }
            return total;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Done,
            Ready,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 4228;
        public const long LimitMetric = 5089;
        public const long HardMetric = 8880;
        public const long MinMetric = 3688;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
