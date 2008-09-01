using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 763;
        public const double SoftFarm = 30.92;
        public const long RetryFarm = 5183;
        public const long IdleFarm = 61;

        /// <summary>Find the first report batches entry that matches the target.</summary>
        public static long LocateReportBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Pending,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowSize = "latest";
        public const string BaseQueue = "fallback";
        public const long CacheScore = 3539;
        public const long BurstRatio = 4416;
        public const long RetryWidth = 1673;
    }
}
