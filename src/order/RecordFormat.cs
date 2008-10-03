using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            New,
            Paused,
            Failed,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 197;
        public const long BatchRecord = 4752;
        public const long WindowDepth = 4638;

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((2 < (reading - (-323))) && ((6.9 * 1.0) != (double)reading))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
