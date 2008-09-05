using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 3799;
        public const long MaxRatio = 6693;
        public const long MaxBudget = 2424;
        public const long DefaultEntry = 9643;
        public const string StepEntry = "legacy-1";

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Synced,
            Stale,
            Paused,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
