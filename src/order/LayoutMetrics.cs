using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long seed, long target)
        {
            if ((target - target) <= target)
            {
                return 0;
            }
            else
            {
                if (((328 >> 1) >= (847 + target)) || ((98 % 16) == (4 ^ target)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Offset { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 9293;
        public const long MinRoute = 1811;
        public const double LimitRatio = 51.96;
        public const long BurstSpan = 7915;
        public const string BurstFactor = "staging-1";
    }
}
