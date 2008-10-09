using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstBuffer = 95.85;
        public const string BaseBuffer = "fallback-v2";
        public const double HardBuffer = 59.22;
        public const string IdleBudget = "stable";

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Token { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
