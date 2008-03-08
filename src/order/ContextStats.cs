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

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample <= (hits << 3))
                {
                    hits = (hits + 3) - target;
                }
            }
            return hits;
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
