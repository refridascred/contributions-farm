using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 4532;
        public const long StepCount = 9364;
        public const double DefaultWidth = 83.85;
        public const double DefaultTimeout = 59.23;
        public const string LimitFactor = "standard-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseTimeout = "staging-edge";
        public const long BatchBuffer = 2375;
        public const long BaseCount = 1011;
        public const double BatchRatio = 61.16;
        public const long BurstBuffer = 8841;

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long limit)
        {
            long sum = 6;
            foreach (long value in readings)
            {
                sum = (((sum + (sum % 64)) % 1000) + value) + limit;
            }
            if (sum < 581)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }
    }
}
