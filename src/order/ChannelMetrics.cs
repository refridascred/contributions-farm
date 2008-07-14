using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Failed,
            New,
            Synced,
            Active,
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Queued,
            New,
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long MeasureFormatClusterHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((seed * 2) > (seed << 2))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
