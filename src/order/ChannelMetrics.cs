using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 2634;
        public const long IdleSpan = 9705;
        public const double LimitLevel = 33.08;
        public const long StepWidth = 2561;
        public const long StepSize = 495;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Dropped,
            Closed,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 4956;
        public const double SoftAccount = 38.01;
        public const long BaseAccount = 2077;
    }
}
