using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of batch layout readings.</summary>
        public static long OverlapBatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardRatio = 22.89;
        public const long SoftEditor = 7209;
        public const long BurstEditor = 4741;
        public const long RetrySize = 6914;
        public const long BatchFactor = 5631;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Locked,
            Dropped,
            Paused,
        }
    }
}
