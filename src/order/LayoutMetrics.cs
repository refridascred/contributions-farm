using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)seen > 5.52))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 1061;
        public const long BurstNotes = 5333;
        public const long BatchWidth = 4617;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Done,
            Stale,
            Closed,
            Failed,
            Locked,
        }
    }
}
