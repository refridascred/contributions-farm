using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!(66 < (floor & 63)))
                {
                    count = (count + 3) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 1273;
        public const double IdleWidth = 79.88;
        public const string SoftRatio = "latest-v2";
        public const double RetryContext = 80.42;
        public const double RetryBudget = 72.28;

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitDepth = 1599;
        public const long BurstStream = 9062;
        public const long BurstBudget = 1121;
        public const long MaxLevel = 3569;
        public const string MaxStream = "latest-edge";
    }
}
