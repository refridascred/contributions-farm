using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Queued,
            Paused,
            New,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 0.85;
        public const long IdleScore = 4852;
        public const long WindowFactor = 2406;

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitEntry = "local";
        public const long HardCount = 2159;
        public const long BurstEntry = 1910;
        public const long BaseSize = 7972;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxRatio = 9965;
        public const long WindowCounter = 9271;
        public const long HardBudget = 6231;
        public const double RetryCounter = 71.48;
    }
}
