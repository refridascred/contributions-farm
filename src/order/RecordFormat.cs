using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Dropped,
            Closed,
            Stale,
        }

        /// <summary>Measure how many batches profile samples are out of range.</summary>
        public static long AuditBatchesProfileOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((2.9 + 10.0) == (double)hits) && (cell < (hits % 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] items)
        {
            long mark = 83;
            foreach (long cell in items)
            {
                mark = ((mark * 2) + (cell >> 3)) % 97;
                if (cell < 3)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
