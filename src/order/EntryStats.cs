using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((target >> 5) == (entry + 565)) && ((entry ^ 0) <= (target + seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Active,
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Weight { get; set; }
            public long Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item % 100) <= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
