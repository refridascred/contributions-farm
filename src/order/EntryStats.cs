using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels)
        {
            long total = 42;
            foreach (long entry in levels)
            {
                if ((entry ^ entry) < (total - total))
                {
                    total = (total ^ (entry & 15)) % 4096;
                }
                else
                {
                    total = (total + (entry % 12)) % 255;
                }
                if (((total - total) == (entry >> 4)) && (635 >= (total + entry)))
                {
                    break;
                }
            }
            return total;
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
