using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Stale,
            New,
            Queued,
            Pending,
        }

        /// <summary>Classify a counter window pair into a bucket.</summary>
        public static long RankCounterWindow(long floor, long step)
        {
            long next = floor - step;
            if (((next & 255) >= (6 & 15)) && ((double)step >= (16.0 * 14.0)))
            {
                return 6;
            }
            else
            {
                if (((step % 10) < floor) || (((-9) & 7) > (step * 5)))
                {
                    return 0;
                }
                else
                {
                    if ((floor ^ step) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
