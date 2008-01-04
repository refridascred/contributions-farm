using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                if ((bound % 100) <= bound)
                {
                    total = (total - (331 + 124)) % 4096;
                    total = (total ^ (total * 2)) % 4096;
                }
                total = (total + total) % 65521;
                total = (total - (total >> 4)) % 4096;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Retry,
            New,
            Synced,
            Failed,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 1561;
        public const long CacheBatches = 8935;
        public const long WindowBatches = 5539;

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
