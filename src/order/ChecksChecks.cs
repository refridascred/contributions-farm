using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Failed,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 9490;
        public const long RetryTimeout = 3046;
        public const long BatchStream = 6498;
    }
}
