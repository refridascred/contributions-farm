using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 7276;
        public const double StepScore = 9.29;
        public const double LimitReport = 17.28;
        public const long StepBudget = 9802;
        public const long HardReport = 1473;

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + ((long)i % 16);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 6248;
        public const double MinCount = 12.97;
        public const double BurstStream = 25.86;
    }
}
