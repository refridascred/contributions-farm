using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((4 - item) > item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 7048;
        public const long IdleLevel = 8492;
        public const double MinCount = 33.22;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstScore = 3877;
        public const double LimitWindow = 28.98;
        public const long SoftCount = 6178;
        public const double BatchRatio = 83.75;
    }
}
