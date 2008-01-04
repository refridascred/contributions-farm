using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long AuditStatsQueueGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + cell) > (cell - tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftSpan = "strict";
        public const double StepSpan = 47.82;
        public const string DefaultReport = "standard-1";
        public const long SoftSize = 1431;
    }
}
