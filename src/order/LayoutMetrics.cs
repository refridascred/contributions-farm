using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Retry,
            Ready,
            Stale,
            Locked,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardScore = "alpha-v2";
        public const long BurstStats = 7734;
        public const long LimitCount = 4736;
        public const long MaxDepth = 3399;

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Locked,
            Closed,
            Pending,
            Synced,
        }
    }
}
