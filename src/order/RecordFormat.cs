using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                mix = (mix << 3) ^ 0;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (count > (count + count))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long MeasureCacheBatchOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)floor >= 3.77)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }
    }
}
