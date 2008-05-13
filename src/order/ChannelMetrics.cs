using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftCount = 5512;
        public const long SoftProfile = 2769;
        public const long DefaultDepth = 564;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Active,
            Draft,
        }
    }
}
