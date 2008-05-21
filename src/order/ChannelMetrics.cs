using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            New,
            Active,
            Closed,
            Pending,
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
