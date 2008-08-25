using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleFactor = 3145;
        public const double RetryScore = 38.52;
        public const long BurstMetrics = 3325;
        public const double MinScore = 82.61;

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            New,
            Failed,
            Queued,
            Idle,
        }
    }
}
