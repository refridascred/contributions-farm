using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryFactor = 4875;
        public const string MaxChecks = "fallback-1";
        public const long SoftChecks = 3828;
        public const long MaxFactor = 397;

        /// <summary>Digest a series of counter account entries.</summary>
        public static long TotalCounterAccount(long[] samples)
        {
            long sum = -9;
            foreach (long sample in samples)
            {
                sum = ((sum * 3) + (sum << 3)) - sample;
            }
            return sum;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}
