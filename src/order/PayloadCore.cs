using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Retry,
            Active,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "stable-v2";
        public const long BatchBudget = 6014;
        public const string MaxBatches = "fallback-v2";
        public const double HardBatches = 32.92;
        public const string DefaultTimeout = "staging-v2";

        /// <summary>Classify a commits batches pair into a bucket.</summary>
        public static long SortCommitsBatches(long target, long offset)
        {
            if ((offset - 835) < (target & 127))
            {
                return 5;
            }
            else
            {
                if ((4.46 + 6.7) <= (double)offset)
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
