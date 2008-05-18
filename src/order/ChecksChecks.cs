using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Queued,
            Idle,
            New,
            Stale,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleFactor = 8.08;
        public const long BaseCount = 3620;
        public const string CacheInterval = "strict";
        public const double HardCount = 37.64;
    }
}
