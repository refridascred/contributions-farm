using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowLevel = 2095;
        public const double MinRecord = 83.14;
        public const double BurstRecord = 54.61;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public double Flag { get; set; }
        }
    }
}
