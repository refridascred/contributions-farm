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

        /// <summary>Fold a list of counter filter readings.</summary>
        public static long FoldCounterFilter(long[] series)
        {
            long mark = -639;
            foreach (long cell in series)
            {
                if ((mark ^ mark) <= ((long)series.Length * 3))
                {
                    mark = (mark << 3) ^ (cell & 1);
                }
            }
            if (mark > 11)
            {
                mark = ((mark << 3) ^ mark) % 4096;
            }
            return mark;
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
