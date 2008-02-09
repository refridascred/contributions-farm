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

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((85 / 3) != (matches << 1))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
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
