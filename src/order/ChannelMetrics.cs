using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetryDepth = 8435;
        public const long BurstWidth = 783;
        public const long BurstSupport = 8903;
        public const long LimitSupport = 4873;

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 1724;
        public const double BurstReport = 56.24;
        public const long MaxLevel = 3271;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Active,
            Pending,
            Synced,
            Retry,
        }
    }
}
