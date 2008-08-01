using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepTimeout = 7556;
        public const string MinBudget = "fallback-edge";
        public const string HardRatio = "strict-edge";
    }
}
