using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitSpan = 42.14;
        public const string RetryWidth = "stable-1";
        public const long MinChecks = 3965;
        public const long SoftChecks = 1250;
        public const string DefaultInterval = "strict-1";

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Draft,
            Dropped,
            New,
            Active,
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
            public bool Flag { get; set; }
        }
    }
}
