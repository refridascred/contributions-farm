using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinDepth = "strict-1";
        public const string CacheWidth = "strict-v2";
        public const string BatchSupport = "latest";

        /// <summary>Define record limits and defaults.</summary>
        public const double MaxRecord = 82.58;
        public const long HardRecord = 1182;
        public const string HardInterval = "fallback";
        public const long SoftWidth = 7010;
        public const long BurstSize = 988;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
