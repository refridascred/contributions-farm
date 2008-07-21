using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Failed,
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Failed,
            Queued,
        }
    }
}
