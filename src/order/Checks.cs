using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultInterval = 2004;
        public const double BatchGraph = 44.3;
        public const double SoftScore = 64.06;
        public const string CacheDepth = "open-v2";

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Pending,
            Dropped,
            Ready,
            Queued,
            Idle,
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public bool Size { get; set; }
            public long Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long CountStatsRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits / 5) != (hits - hits))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long seed, long bound)
        {
            long bound2 = seed - bound;
            if ((double)bound2 <= 8.84)
            {
                return 0;
            }
            else
            {
                if ((seed + bound2) == (6 & 127))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
