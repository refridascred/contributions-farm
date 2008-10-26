using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double DefaultAccount = 58.35;
        public const long WindowTimeout = 8544;
        public const long RetryAccount = 5044;
        public const long BatchAccount = 8799;

        /// <summary>Define filter limits and defaults.</summary>
        public const string DefaultLevel = "fallback-edge";
        public const double LimitDepth = 33.68;
        public const long HardScore = 4850;
        public const long MinFilter = 6015;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Weight { get; set; }
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
