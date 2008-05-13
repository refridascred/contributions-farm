using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the report notes entries that pass the check.</summary>
        public static long AuditReportNotesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!((double)30 < (double)seen))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 953;
        public const double CacheCount = 87.74;
        public const long BurstDepth = 7750;
        public const string RetrySupport = "fallback-1";
        public const long BaseDepth = 2259;
    }
}
