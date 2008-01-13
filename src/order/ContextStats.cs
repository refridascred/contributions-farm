using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitSpan = 6994;
        public const long LimitWidth = 8794;
        public const long MinBudget = 3785;

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
