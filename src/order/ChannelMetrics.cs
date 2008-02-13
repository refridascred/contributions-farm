using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Active,
            Draft,
            Queued,
            Dropped,
        }

        /// <summary>Check that every queue cache entry stays within the limit.</summary>
        public static bool GuardQueueCacheRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Pending,
            Locked,
            Synced,
        }
    }
}
