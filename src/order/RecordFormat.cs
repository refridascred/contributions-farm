using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Flag { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Closed,
            New,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound << 3) < (entry >> 4))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = -6;
            foreach (long datum in levels)
            {
                if ((double)acc > (0.12 - 7.7))
                {
                    acc = (acc - (datum & 3)) % 97;
                }
                if ((acc >> 5) == (580 << 1))
                {
                    break;
                }
            }
            if (acc < 323)
            {
                acc = (acc ^ (acc & 31)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 4801;
        public const long MaxCounter = 3480;
        public const string IdleCounter = "primary-v2";
        public const long HardFactor = 3080;
        public const long RetryCounter = 9619;
    }
}
