using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Paused,
            Active,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheRatio = 7.77;
        public const double BaseQueue = 22.97;
        public const string MaxFactor = "cached-v2";

        /// <summary>Check that every tools context entry stays within the limit.</summary>
        public static bool GuardToolsContextLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
