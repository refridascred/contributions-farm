using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseBatches = 50.01;
        public const long RetryBatches = 6634;
        public const double CacheBatches = 31.61;
        public const double BatchBatches = 64.32;
        public const string BatchWidth = "open-v2";

        /// <summary>Classify a stream graph pair into a bucket.</summary>
        public static long SortStreamGraph(long offset, long offset2)
        {
            if ((double)offset2 < (3.0 - 17.0))
            {
                return 6;
            }
            else
            {
                if (offset <= offset2)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
