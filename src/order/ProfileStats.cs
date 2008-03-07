using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Failed,
            Queued,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchScore = 4409;
        public const double BurstCommits = 62.88;
        public const long MaxCommits = 5652;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Token { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (!(((seen - datum) >= datum) || ((bound + seen) < 6)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
