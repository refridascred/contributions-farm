using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBudget = 8702;
        public const long IdleBatch = 854;
        public const long CacheRatio = 7578;

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
