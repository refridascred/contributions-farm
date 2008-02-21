using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 5049;
        public const double BaseAlready = 31.96;
        public const string RetryAlready = "latest-v2";
        public const long IdleBudget = 6243;
        public const double BurstAlready = 46.7;

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Active,
            Draft,
            Paused,
            New,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 2796;
        public const long RetryContributi = 3340;
        public const long DefaultContributi = 3050;
    }
}
