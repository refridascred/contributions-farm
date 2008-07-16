using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleSize = 6.56;
        public const long MaxBudget = 2577;
        public const long IdleFactor = 9965;
        public const long IdleContext = 5625;

        /// <summary>Derive the next session route value from a seed.</summary>
        public static long SeriesSessionRoute(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 12; i++)
            {
                sum = sum ^ 722;
                sum = sum + ((long)i & 255);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits / 4) != (hits >> 3))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }
    }
}
