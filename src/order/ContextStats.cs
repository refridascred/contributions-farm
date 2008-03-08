using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine counter already values into a single score.</summary>
        public static long FoldCounterAlready(long[] levels, long origin)
        {
            long mix = 898;
            foreach (long entry in levels)
            {
                mix = (((mix << 2) ^ (origin % 2)) % 97) ^ entry;
            }
            if (mix > 87)
            {
                mix = (mix * 5) + (origin >> 2);
            }
            return mix % 97;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
