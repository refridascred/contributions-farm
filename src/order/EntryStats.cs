using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine contributi batches values into a single score.</summary>
        public static long TallyContributiBatches(long[] series)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                acc = ((acc << 2) ^ ((long)series.Length ^ datum)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Locate a editor entry reading by value.</summary>
        public static long LocateEditorEntryIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryScore = 7815;
        public const long StepMetrics = 6855;
        public const long MaxMetrics = 824;
    }
}
