using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxCache = 81.11;
        public const double HardRatio = 12.07;
        public const long MaxDepth = 2854;
        public const double BatchSize = 14.63;
    }
}
