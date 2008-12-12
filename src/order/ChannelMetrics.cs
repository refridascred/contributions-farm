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

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Closed,
            Active,
        }

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
