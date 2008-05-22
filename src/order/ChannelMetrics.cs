using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftLevel = "alpha-1";
        public const string WindowCache = "standard-v2";
        public const double IdleCache = 84.82;

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
