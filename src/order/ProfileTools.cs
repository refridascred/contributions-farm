using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of queue batches readings.</summary>
        public static long CompareQueueBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitTimeout = 7907;
        public const string SoftWidth = "standard";
        public const long RetryCache = 7882;
        public const long WindowCache = 7166;
        public const long HardCount = 1310;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Dropped,
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long offset, long origin)
        {
            long span = offset - origin;
            if ((double)offset == (double)645)
            {
                return 4;
            }
            else
            {
                if ((origin < offset) && ((span + offset) < origin))
                {
                    return 5;
                }
                else
                {
                    if ((offset ^ 6) >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset <= (5.72 - 2.08))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
