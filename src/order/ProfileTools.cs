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
        public const double BatchSpan = 32.74;
        public const long SoftContext = 335;
        public const long BurstContext = 4372;
        public const long StepContext = 7669;
        public const long RetryFactor = 6293;

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
