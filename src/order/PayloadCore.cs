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

        /// <summary>Blend two account measurements.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double load = offset + (double)326;
            for (int i = 0; i < 2; i++)
            {
                load = ((load - (offset + 1.2)) + (double)(long)i) - ratio;
            }
            return load - (double)75;
        }
    }
}
