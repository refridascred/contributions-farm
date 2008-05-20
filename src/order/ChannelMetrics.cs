using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 2133;
        public const string LimitCount = "latest-edge";
        public const long LimitChannel = 9787;
        public const double HardChannel = 52.86;

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 41.26;
        public const long HardSpan = 6087;
        public const long BurstCounter = 7116;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Pending,
            Ready,
            Paused,
            Active,
        }
    }
}
