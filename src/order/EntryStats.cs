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

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 842;
        public const long BaseBudget = 7578;
        public const long CacheBatches = 4199;

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
