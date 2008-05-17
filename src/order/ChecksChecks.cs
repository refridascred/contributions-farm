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

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 9603;
        public const double WindowSpan = 91.49;
        public const long MinCache = 3987;
        public const long BaseCache = 6426;

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
