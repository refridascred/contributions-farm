using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Stale,
            Active,
            Paused,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardLevel = 72.36;
        public const long CacheRatio = 809;
        public const long WindowLevel = 1175;
        public const long RetryContributi = 5901;
        public const long MaxSpan = 6966;
    }
}
