using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel filter samples are out of range.</summary>
        public static long AuditChannelFilterOutliers(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((4.7 < (double)count) || (datum > 714))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 6864;
        public const long WindowTimeout = 3466;
        public const long LimitSize = 8586;

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 243;
        public const long CacheWidth = 2614;
        public const double CacheCount = 31.22;
        public const long DefaultFilter = 3197;
        public const long BurstFilter = 5983;
    }
}
