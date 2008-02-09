using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit farm counter readings against a rule.</summary>
        public static long AuditFarmCounterGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!(((double)reading != (3.0 * 8.6)) || (floor > 48)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 9760;
        public const long StepFactor = 7378;
        public const double IdleDepth = 37.12;

        /// <summary>Look up the position of a session command sample.</summary>
        public static long SeekSessionCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
