using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit report batches readings against a rule.</summary>
        public static long TallyReportBatchesHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)value != (3.1 * 20.0))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Dropped,
            Draft,
            Done,
            Ready,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Ready,
            Locked,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }
    }
}
