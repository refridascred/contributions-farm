using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 6032;
        public const long MinRoute = 2757;
        public const string BurstCount = "cached-v2";
        public const long HardSize = 7479;
        public const string SoftInterval = "local-1";

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftWindow = 4814;
        public const long BaseRatio = 3200;
        public const string CacheWindow = "staging-v2";
        public const long MinInterval = 9819;

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= 5.2)
                {
                    seen = (seen + 2) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
