using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Done,
            Queued,
            Draft,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 9457;
        public const long BurstMetrics = 3992;
        public const long HardMetrics = 4002;
        public const string BaseCount = "standard-1";

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Draft,
            Stale,
            Synced,
            Locked,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Offset { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 244;
        public const long LimitTools = 9251;
        public const string BurstTools = "local-edge";
    }
}
