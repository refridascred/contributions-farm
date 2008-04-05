using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 9468;
        public const double MaxSession = 88.83;
        public const string SoftBudget = "strict-v2";
        public const long RetrySession = 4794;
        public const long WindowSession = 158;

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] readings, long seed)
        {
            long acc = 812;
            foreach (long value in readings)
            {
                if ((double)acc == (double)seed)
                {
                    acc = (acc ^ (acc + value)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 5744;
        public const long StepRecord = 1527;
        public const double SoftRecord = 13.12;
        public const long RetryRecord = 7686;
        public const long MaxCount = 2644;
    }
}
