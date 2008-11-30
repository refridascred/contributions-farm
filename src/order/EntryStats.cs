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

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels, long offset)
        {
            long total = 14;
            foreach (long datum in levels)
            {
                total = (((total * 3) + (total + 37)) % 1000) ^ datum;
            }
            if (total > 2)
            {
                total = (total << 2) ^ (offset % 100);
            }
            return total;
        }
    }
}
