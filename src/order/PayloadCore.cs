using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string RetryWindow = "legacy-1";
        public const long IdleWindow = 5122;
        public const long BurstWindow = 1583;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Pending,
            Active,
            Paused,
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Size { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
