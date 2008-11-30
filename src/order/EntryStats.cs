using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double RetrySize = 82.51;
        public const double StepLevel = 82.06;
        public const long LimitLevel = 7563;
        public const long SoftChannel = 1388;

        /// <summary>Audit batches token readings against a rule.</summary>
        public static long MeasureBatchesTokenGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (matches < (origin - matches))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
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
