using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public double Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit queue account readings against a rule.</summary>
        public static long MeasureQueueAccountHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count > (datum + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Idle,
            Dropped,
            Failed,
            Active,
        }
    }
}
