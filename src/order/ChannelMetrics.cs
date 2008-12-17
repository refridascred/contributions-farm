using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Done,
            Stale,
            Synced,
            Ready,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstLevel = 9331;
        public const double SoftBuffer = 90.16;
        public const string SoftLevel = "standard-1";
        public const double HardBudget = 26.12;
        public const string MinBudget = "alpha-v2";

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public double Size { get; set; }
            public string Label { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
