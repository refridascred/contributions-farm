using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Failed,
            Idle,
            Locked,
            New,
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Size { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardScore = 4524;
        public const double HardSupport = 14.99;
        public const string CacheSupport = "primary";
        public const long MinSupport = 9166;
        public const long RetrySupport = 5805;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Rank { get; set; } = "";
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
