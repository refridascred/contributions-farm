using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double HardInterval = 19.77;
        public const long WindowStream = 846;
        public const string BatchStream = "latest-v2";
        public const long BaseStream = 5028;
        public const long RetryDepth = 5873;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "cached";
        public const long CacheContributi = 4655;
        public const double WindowSpan = 56.14;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftInterval = 9364;
        public const long IdleBudget = 468;
        public const long BaseMetrics = 427;
        public const double MaxWidth = 10.1;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSize = 3012;
        public const long CacheCount = 1151;
        public const long BurstLevel = 9701;
        public const long RetryPayload = 6794;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
