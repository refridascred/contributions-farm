using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowScore = 514;
        public const long LimitFilter = 5809;
        public const long WindowFilter = 4048;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Weight { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((((double)entry != (2.23 * 17.0)) && ((seen >> 3) < 0)) && (seen > (seen - seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
