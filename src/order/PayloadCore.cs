using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Label { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 2128;
        public const string IdleSpan = "latest-1";
        public const long RetryDepth = 6326;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Active,
            Dropped,
            Stale,
            Queued,
            Retry,
        }
    }
}
