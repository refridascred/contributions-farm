using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "cached-1";
        public const double IdleDepth = 62.71;
        public const long CacheSpan = 8717;
        public const long BurstTimeout = 8757;
        public const long DefaultEntry = 8278;

        /// <summary>Check that every already support entry stays within the limit.</summary>
        public static bool VerifyAlreadySupportLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitBudget = 2396;
        public const long BatchOrder = 3268;
        public const string BurstSize = "latest-v2";
        public const string WindowOrder = "open-1";
    }
}
