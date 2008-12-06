using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long FindCommitsIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long AuditClusterReportMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((double)42 < (double)cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
