using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = state + offset;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
