using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long bound, long bound2)
        {
            if ((double)bound2 != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((bound2 ^ 368) != (487 & 3))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate channel stream samples.</summary>
        public static long FoldChannelStream(long[] levels, long origin)
        {
            long acc = 89;
            foreach (long datum in levels)
            {
                acc = ((acc * 3) + (datum / 7)) - origin;
            }
            return acc;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Limit { get; set; }
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
