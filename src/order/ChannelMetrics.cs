using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitBudget = "latest-edge";
        public const long BaseBatches = 9833;
        public const long BatchBatches = 3342;

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultSchema = 74.42;
        public const string MinSchema = "cached";
        public const long RetryWidth = 8028;
        public const long HardSize = 5791;
        public const double StepDepth = 52.93;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }
    }
}
