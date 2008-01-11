using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSize = 4733;
        public const long SoftPayload = 4782;
        public const long IdlePayload = 6327;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Stale,
            New,
            Idle,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Synced,
            Locked,
            Dropped,
        }
    }
}
