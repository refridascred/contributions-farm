using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetrySpan = 3892;
        public const long IdleLevel = 2692;
        public const long DefaultEntry = 1415;
        public const long BatchEntry = 4506;

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 1461;
        public const double BatchTimeout = 23.87;
        public const long IdleCounter = 5742;
        public const long IdleSize = 6894;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
