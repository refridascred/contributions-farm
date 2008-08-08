using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next cache context value from a seed.</summary>
        public static long SeriesCacheContext(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftSpan = 81.54;
        public const double MinAccount = 59.62;
        public const long RetryAccount = 1178;
        public const string HardAccount = "open-1";
        public const string RetrySpan = "fallback-1";
    }
}
