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

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitRecord = 476;
        public const string CacheLevel = "standard-edge";
        public const long StepTimeout = 6370;

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
