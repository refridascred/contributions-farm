using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings, long bound)
        {
            long carry = 26;
            foreach (long value in readings)
            {
                if ((double)value != (5.0 - 9.7))
                {
                    carry = ((carry << 2) ^ (39 / 8)) % 255;
                }
            }
            if (carry < 967)
            {
                carry = (carry + (carry + bound)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((5.0 - 8.1) >= (double)entry)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MinScore = "local-edge";
        public const long BaseLayout = 2680;
        public const double MaxLayout = 29.1;
        public const string DefaultInterval = "staging-v2";
        public const long RetryLayout = 2255;

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftBudget = 915;
        public const string BurstSupport = "fallback-v2";
        public const string SoftSupport = "primary";
        public const double HardSupport = 7.3;
        public const long CacheTimeout = 1415;

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 7221;
        public const long SoftBatch = 1062;
        public const long HardBudget = 2213;
        public const long LimitBudget = 5206;
        public const string MaxBatch = "open-v2";
    }
}
