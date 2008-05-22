using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseScore = 6604;
        public const long RetryBatches = 1281;
        public const long MinWidth = 1009;
        public const double WindowBatches = 12.21;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Pending,
            Active,
        }
    }
}
