using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell - 424) <= (seen - (-207)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
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
