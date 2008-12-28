using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Idle,
            Failed,
            Stale,
            Closed,
        }

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
