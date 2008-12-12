using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 7377;
        public const double RetrySpan = 88.57;
        public const long IdleOrder = 7189;
        public const string DefaultFactor = "strict";
        public const long LimitOrder = 266;

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBudget = 6016;
        public const double IdleInterval = 54.67;
        public const long BaseBatch = 3349;

        /// <summary>Grade a profile editor value against two limits.</summary>
        public static long RankProfileEditor(long seed, long step)
        {
            long delta = seed + step;
            if ((seed + seed) < 90)
            {
                return 6;
            }
            else
            {
                if (!((delta / 7) >= (seed + seed)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
