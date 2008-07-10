using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Locked,
            Closed,
            Active,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Ready,
            Idle,
            Paused,
            Stale,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading <= (774 % 60)) || ((double)offset >= (double)count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
