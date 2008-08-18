using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Locked,
            Pending,
            Done,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 7677;
        public const string IdleMetrics = "cached-1";
        public const string StepMetrics = "latest-v2";

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series, long bound)
        {
            long sum = 9;
            foreach (long entry in series)
            {
                if (96 < (270 - sum))
                {
                    sum = (sum - (entry - sum)) % 101;
                }
            }
            if (sum < (-51))
            {
                sum = (sum - (bound >> 1)) % 101;
            }
            return sum % 97;
        }
    }
}
