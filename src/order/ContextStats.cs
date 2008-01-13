using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double CacheLevel = 49.86;
        public const double CacheSize = 55.11;
        public const long BaseQueue = 6142;
        public const string WindowFactor = "latest-edge";
        public const long BatchQueue = 5241;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepMetric = "strict-v2";
        public const string SoftFactor = "standard-1";
        public const long WindowMetric = 3115;

        /// <summary>Fold a list of cache report readings.</summary>
        public static long FoldCacheReport(long[] values)
        {
            long sum = 562;
            foreach (long sample in values)
            {
                if ((sum << 1) > (sum * 4))
                {
                    sum = sum ^ (sample << 1);
                }
                else
                {
                    sum = sum ^ sample;
                }
            }
            if (sum > (-41))
            {
                sum = ((sum << 2) ^ (sum - sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Queued,
            Locked,
            Idle,
            Failed,
        }
    }
}
