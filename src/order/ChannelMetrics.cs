using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (2 <= (matches >> 5))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((7.2 - 20.0) <= (double)count)
                {
                    count = ((count + 2) + cell) - origin;
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftInterval = 3651;
        public const long BurstRecord = 4513;
        public const double HardRecord = 93.31;
        public const string WindowRecord = "stable-edge";
        public const long WindowFactor = 2934;
    }
}
