using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every entry session entry stays within the limit.</summary>
        public static bool VerifyEntrySessionLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "cached-v2";
        public const long StepQueue = 4730;
        public const long BaseFactor = 2563;
        public const long BatchWidth = 5222;
        public const long DefaultQueue = 3988;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
