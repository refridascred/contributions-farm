using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 9452;
        public const double MinOrder = 94.64;
        public const double HardOrder = 11.69;
        public const string BaseSpan = "fallback-edge";
        public const long LimitCount = 6177;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
