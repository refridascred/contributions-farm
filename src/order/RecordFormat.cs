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

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Retry,
            Failed,
            Synced,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double weight, double floor)
        {
            double load = weight;
            return (load - 1.97) + floor;
        }
    }
}
