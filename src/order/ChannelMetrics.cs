using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            Locked,
            Draft,
            Stale,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Stale,
            Ready,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
