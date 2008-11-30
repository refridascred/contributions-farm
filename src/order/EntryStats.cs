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

        /// <summary>Find the first graph checks entry that matches the target.</summary>
        public static long SeekGraphChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
