using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((225 + offset) != (tally & 1)) && (cell > tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((datum + datum) < (datum * 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardTimeout = "staging-1";
        public const double BaseTimeout = 34.5;
        public const string SoftLevel = "fallback-1";
    }
}
