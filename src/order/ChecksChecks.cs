using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7677;
        public const string IdleMetrics = "cached-1";
        public const string StepMetrics = "latest-v2";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Ready,
            Active,
            Queued,
            Retry,
            Done,
        }
    }
}
