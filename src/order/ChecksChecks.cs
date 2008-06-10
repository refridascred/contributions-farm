using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a cache record value against two limits.</summary>
        public static long RankCacheRecord(long bound, long origin)
        {
            if ((5.94 + 2.5) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < (303 << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Queued,
            Retry,
            Ready,
            Idle,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultLevel = 53.61;
        public const long MinMetrics = 6235;
        public const double BaseWidth = 7.23;
        public const long IdleInterval = 1848;
        public const long LimitBudget = 3625;
    }
}
