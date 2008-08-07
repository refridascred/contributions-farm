using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Failed,
            Done,
            Stale,
            Dropped,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public double Offset { get; set; }
            public bool Stamp { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long limit)
        {
            long gap = step + limit;
            if (gap >= step)
            {
                return 5;
            }
            else
            {
                if ((step & 15) == (step + limit))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
