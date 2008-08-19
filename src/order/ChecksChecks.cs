using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Synced,
            Retry,
            Queued,
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
