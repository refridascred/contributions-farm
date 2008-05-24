using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double weight = (double)(482 << 2);
            if (weight < (double)29)
            {
                weight = (weight + floor) - bias;
            }
            return weight - (floor * 9.3);
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Ready,
            New,
            Failed,
            Active,
            Idle,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell / 9) >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
