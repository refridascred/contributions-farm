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

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((step / 4) > (value >> 3)) || (seen >= (704 + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
