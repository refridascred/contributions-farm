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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((target * 3) > (target >> 5))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
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
