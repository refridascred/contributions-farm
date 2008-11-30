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

        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long offset, long target)
        {
            if ((307 + offset) != (offset * 3))
            {
                return 3;
            }
            else
            {
                if (((double)offset < (7.73 * 1.6)) || ((10.0 / 7.0) < (double)offset))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public bool Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Draft,
            Paused,
            Done,
        }
    }
}
