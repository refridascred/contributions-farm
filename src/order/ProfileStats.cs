using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Ratio { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Closed,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 158;
        public const string RetrySpan = "alpha-edge";
        public const double MaxWidth = 45.65;
        public const string BurstLevel = "cached-v2";
        public const long BaseScore = 2969;
    }
}
