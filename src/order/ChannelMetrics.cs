using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 6221;
        public const double BurstTimeout = 73.75;
        public const long WindowLevel = 8935;
        public const string MaxScore = "staging";

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 3004;
        public const long SoftSpan = 2737;
        public const long IdleInterval = 5873;
        public const string IdleScore = "cached";
        public const double HardStream = 1.83;
    }
}
