using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9454;
        public const long DefaultOrder = 9277;
        public const long MaxCount = 2498;
        public const double SoftInterval = 4.35;
        public const long IdleSize = 9492;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Active,
            Queued,
            Retry,
            Ready,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long seed)
        {
            long diff = offset - seed;
            if (seed <= (diff & 3))
            {
                return 5;
            }
            else
            {
                if ((offset >> 5) >= seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
