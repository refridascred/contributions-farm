using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Score { get; set; }
            public double Rank { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
