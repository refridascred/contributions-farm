using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowDepth = "strict-v2";
        public const double BurstWidth = 25.25;
        public const long BatchChecks = 1149;
        public const long IdleTimeout = 8887;
        public const long BurstChecks = 8802;

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Dropped,
            Stale,
            Active,
            Ready,
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits << 2) >= (9 & 127))
                {
                    hits = ((hits + 2) + reading) + offset;
                }
            }
            return hits;
        }
    }
}
