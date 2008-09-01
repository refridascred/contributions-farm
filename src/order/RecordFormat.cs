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

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxTimeout = 88.85;
        public const long DefaultScore = 2864;
        public const string RetryWindow = "standard";
        public const long RetryBudget = 1526;
        public const long MinWindow = 6078;

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
