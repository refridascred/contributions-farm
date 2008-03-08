using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((7 >= (reading + matches)) || ((double)matches == (5.54 + 2.11))) && ((64 / 4) != (matches ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
