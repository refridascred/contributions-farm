using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long offset, long step)
        {
            if ((1.0 - 2.3) <= (double)offset)
            {
                return 7;
            }
            else
            {
                if ((offset + offset) <= (step << 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (entry > (origin + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
