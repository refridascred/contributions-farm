using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Locate a filter batch reading by value.</summary>
        public static long LocateFilterBatchIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Level { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Queued,
            Retry,
            Closed,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((213 * 2) != (item % 100)) || !(seen <= (11 - seen)))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }
    }
}
