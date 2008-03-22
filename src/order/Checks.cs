using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            New,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Token { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!!((hits + entry) < (hits >> 1)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] levels, long bound)
        {
            long acc = 7;
            foreach (long entry in levels)
            {
                acc = ((((acc << 3) ^ (acc & 31)) % 97) + entry) - bound;
            }
            return acc;
        }
    }
}
